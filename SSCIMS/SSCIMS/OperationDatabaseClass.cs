using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;//访问Access需要
using System.Data.SqlClient;//访问SQL Server需要
using System.Windows.Forms;//Messagebox需要
using System.Collections;


namespace SSCIMS
{
    class OperationDatabaseClass
    {
        #region 连接数据库变量

        public SqlConnection eSqlConnection = new SqlConnection("Data Source=.;Initial Catalog=DataBaseSSCIMS;Integrated Security=True");

        public SqlCommand eSqlCommand = new SqlCommand();

        public SqlDataAdapter eSqlDataAdapter = new SqlDataAdapter();

        public string eSqlstring = null;

        public string ProjectString = null;

        public string WhereString = null;

        public DataSet eDataSet = new DataSet();

        public DataView eDataView = new DataView();

        #endregion

        /// <summary>
        /// TableName表名,TableIDValue关键字的值，InsertValue是插入值的SQL字符串
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="tableID"></param>
        /// <param name="sqlstring"></param>
        public void Insert(string TableName, string TableIDValue, string InsertValue)
        {
            eSqlConnection.Open();
            try
            {
                eSqlCommand.Connection = eSqlConnection;
                if (TableIDValue != "")
                {
                    eSqlCommand.CommandText = "select * from " + TableName + " where " + TableIDValue;
                    if (eSqlCommand.ExecuteScalar() == null)
                    {
                        eSqlCommand.CommandText = "insert into " + TableName + " select " + InsertValue;
                        eSqlCommand.ExecuteNonQuery();
                        MessageBox.Show("新信息添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("ID信息已经存在！");
                    }
                }//单个插入记录
                else
                {
                    eSqlCommand.CommandText = "insert into " + TableName + " select " + InsertValue;
                    eSqlCommand.ExecuteNonQuery();
                    //MessageBox.Show("新信息添加成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "     数据添加操作失败!");
            }
            eSqlConnection.Close();
        }

        /// <summary>
        /// tablename表名,sqlstring的SQL字符串
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="sqlstring"></param>
        /// <returns></returns>
        public DataView Query(string TableName, string ProjectionString,string WhereString)
        {
            eSqlConnection.Open();
            if (WhereString == "")
            {
                eSqlstring = "select " + ProjectionString + " from " + TableName;
            }
            else
            {
                eSqlstring = "select " + ProjectionString + " from " + TableName + " where " + WhereString;
            }

            SqlDataAdapter eSqlDataAdapter = new SqlDataAdapter(eSqlstring, eSqlConnection);
            eDataSet.Tables.Clear();
            eDataSet.Clear();
            eSqlDataAdapter.Fill(eDataSet, TableName);
            eSqlConnection.Close();
            eDataSet.Tables[TableName].DefaultView.AllowNew = false;
            return eDataSet.Tables[TableName].DefaultView;
        }

        /// <summary>
        /// tablename表名,UpdateString更新语句，WhereString条件字符串,SingleUpdate表示是否为单次更新
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="tableID"></param>
        /// <param name="ptableID"></param>
        /// <param name="sqlstring"></param>
        public bool Update(string TableName, string WhereString, string UpdateString,bool SingleUpdate)
        {
            bool ReturnValue;
            eSqlConnection.Open();
            try
            {
                eSqlCommand.Connection = eSqlConnection;
                if (WhereString != "")
                {
                    eSqlCommand.CommandText = "update " + TableName + " set " + UpdateString + " where " + WhereString;
                }
                else
                {
                    eSqlCommand.CommandText = "update " + TableName + " set " + UpdateString;
                }
                eSqlCommand.ExecuteNonQuery();
                if (SingleUpdate)
                {
                    MessageBox.Show("修改操作成功！");
                }
                ReturnValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + WhereString + "     数据库更新操作失败!");
                ReturnValue = false;
            }
            eSqlConnection.Close();
            return ReturnValue;
        }

        /// <summary>
        /// 删除记录,TableName为删除表,DeleteString为删除条件字符串
        /// </summary>
        public void Delete(string TableName, string DeleteString)
        {
            if (MessageBox.Show("确定要删除吗?", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                eSqlConnection.Open();
                try
                {
                    eSqlCommand.Connection = eSqlConnection;
                    if (DeleteString != "")
                    {
                        eSqlCommand.CommandText = "delete  from " + TableName + " where " + DeleteString;
                    }
                    else
                    {
                        eSqlCommand.CommandText = "delete  from " + TableName;
                    }
                    eSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("删除操作成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "     数据库删除操作失败!");
                }
                eSqlConnection.Close();
            }
          
        }

        /// <summary>
        /// Apriori算法
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="MinSupport"></param>
        /// <returns></returns>
        public ArrayList Apriori(string TableName, int MinSupport)
        {
            int i = 0, j = 0;
            int FiledsNum = 0;
            string condition = "";
            ArrayList FrequentSet = new ArrayList();
            ArrayList MidSet = new ArrayList();
            ArrayList CandidateSet = new ArrayList();
            ArrayList Mid = new ArrayList();

            GC.Collect();
            eSqlConnection.Open();
            eSqlstring = "select * from [" + TableName + "]";
            eSqlDataAdapter = new SqlDataAdapter(eSqlstring, eSqlConnection);
            eSqlDataAdapter.Fill(eDataSet, "MyData");

            FiledsNum = eDataSet.Tables["MyData"].Columns.Count;

            for (i = 0; i < FiledsNum; i++)
            {
                GC.Collect();
                condition = eDataSet.Tables["MyData"].Columns[i].ToString() + " = 'Y'";
                if (Support(condition, TableName) >= MinSupport)
                {
                    FrequentSet.Add(eDataSet.Tables["MyData"].Columns[i].ToString());
                    MidSet.Add(eDataSet.Tables["MyData"].Columns[i].ToString());
                    Mid.Add(Support(condition, TableName));
                }
            } //generate 1-frequent

            //FrequentAttributeFormat(Mid);
            for (i = 0; i < MidSet.Count; i++)
            {
                GC.Collect();
                for (j = i + 1; j < MidSet.Count; j++)
                {
                    condition = MidSet[i].ToString() + "," + MidSet[j].ToString();
                    CandidateSet.Add(condition);
                }
            }//connection 2-candidate
            MidSet.Clear();
            while (CandidateSet.Count != 0)
            {
                GC.Collect();
                for (i = 0; i < CandidateSet.Count; i++)
                {
                    condition = ConditionString(CandidateSet[i].ToString());
                    if (Support(condition, TableName) >= MinSupport)
                    {
                        DeleteFrequentSubset(CandidateSet[i].ToString(), FrequentSet, ",");
                        FrequentSet.Add(CandidateSet[i].ToString());
                        MidSet.Add(CandidateSet[i].ToString());
                    }
                }//generate k-frequent itemset
                CandidateSet.Clear();
                if (MidSet.Count != 0)
                {
                    ConnectCandidate(MidSet, FrequentSet, CandidateSet, ",");
                    MidSet.Clear();
                }//connection (k+1)-candidate
            }
            eSqlConnection.Close();
            return FrequentSet;
        }

        #region 自定义函数
        /// <summary>
        /// 在tablename中计算candidate的支持数，用SQL计算
        /// </summary>
        /// <param name="displayFileds"></param>
        /// <param name="candidate"></param>
        /// <param name="tablename"></param>
        /// <returns></returns>
        private int Support(string candidate, string tablename)
        {
            int support = 0;
            GC.Collect();
            eSqlstring = "select * from [" + tablename + "] where " + candidate;
            eSqlDataAdapter = new SqlDataAdapter(eSqlstring, eSqlConnection);
            eSqlDataAdapter.Fill(eDataSet, "Frequent");
            support = eDataSet.Tables["Frequent"].Rows.Count;
            eDataSet.Tables.Remove("Frequent");
            return support;
        }

        /// <summary>
        /// 返回where条件的字符串
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        private string ConditionString(string candidate)
        {
            string Returnstring = "";
            candidate = candidate + ",";
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i].ToString() != ",")
                {
                    Returnstring = Returnstring + candidate[i];
                }
                else
                {
                    Returnstring = Returnstring + " = 'Y' " + "and ";
                }
            }
            candidate = Returnstring.Remove(Returnstring.Length - 4);
            return candidate;
        }

        /// <summary>
        /// 从itemsets中删除item的子集
        /// </summary>
        /// <param name="item"></param>
        /// <param name="itemsets"></param>
        /// <param name="identify"></param>
        private void DeleteFrequentSubset(string item, ArrayList itemsets, string identify)
        {
            if (itemsets.Count != 0)
            {
                if (LengthChar(item, identify) > 1)
                {
                    int i = 0;
                    while (i < itemsets.Count)
                    {
                        if (Contain(itemsets[i].ToString(), item, identify) && (LengthChar(item, identify) != LengthChar(itemsets[i].ToString(), identify)))
                        {
                            itemsets.Remove(itemsets[i]);
                            itemsets.TrimToSize();
                            //i = 0;
                        }
                        else
                        {
                            i = i + 1;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 返回按identify分隔字符串的个数
        /// </summary>
        /// <param name="items"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private int LengthChar(string items, string identify)
        {
            int length = 0, i = 0;
            string mid = "";
            if (items.Length > 0)
            {
                if (items.Contains(identify))
                {
                    mid = items;
                    length = 0;
                    while (mid.Contains(identify))
                    {
                        length = length + 1;
                        i = mid.IndexOf(identify);
                        mid = mid.Remove(0, i + 1);
                    }
                    length = length + 1;
                }
                else
                {
                    length = 1;
                }
            }
            else
            {
                length = 0;
            }
            return length;
        }

        /// <summary>
        /// item是否包含在以identify分隔的字符串中
        /// </summary>
        /// <param name="item"></param>
        /// <param name="set"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private bool Contain(string item, string set, string identify)
        {
            bool result = true;
            int i = 0;
            ArrayList itemA = new ArrayList();
            ArrayList setA = new ArrayList();

            itemA = stringArray(item, identify);
            setA = stringArray(set, identify);
            if (itemA.Count <= setA.Count)
            {
                i = 0;
                while ((i < itemA.Count) && (result))
                {
                    if (!setA.Contains(itemA[i]))
                    {
                        result = false;
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 将以identify分隔item字符串转换成数组存储
        /// </summary>
        /// <param name="item"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private ArrayList stringArray(string item, string identify)
        {
            ArrayList result = new ArrayList();
            int i = 0, L = 0, index = 0;
            string mid = "", midstr = "";

            if (item.Length != 0)
            {
                if (item.Contains(identify))
                {
                    mid = item;
                    L = LengthChar(item, identify);
                    for (i = 1; i < L; i++)
                    {
                        index = mid.IndexOf(identify);
                        midstr = mid.Substring(0, index);
                        result.Add(midstr);
                        mid = mid.Remove(0, index + 1);
                        if (i == L - 1)
                        {
                            result.Add(mid);
                        }
                    }
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }


        /// <summary>
        /// 连接(k-1)-frequent得到k-candidate
        /// </summary>
        /// <param name="midset"></param>
        /// <param name="frequentset"></param>
        /// <param name="candidate"></param>
        /// <param name="identify"></param>
        private void ConnectCandidate(ArrayList midset, ArrayList frequentset, ArrayList candidate, string identify)
        {
            int i = 0, j = 0;
            string Unionstring = "";
            for (i = 0; i < midset.Count; i++)
            {
                for (j = i + 1; j < midset.Count; j++)
                {
                    Unionstring = ConnectionString(midset[i].ToString(), midset[j].ToString(), identify);
                    if (Unionstring != null)
                    {
                        if (CheckSubsetinFrequent(frequentset, Subset(Unionstring, identify), identify))
                        {
                            candidate.Add(Unionstring);
                        }
                    }
                }

            }
        }
        /// <summary>
        /// 求一个字符集合的(k-1)子集，字符集合以identify区分
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private ArrayList Subset(string set, string identify)
        {
            int i = 0, n = 0;
            ArrayList SubsetResult = new ArrayList();
            ArrayList ArraySet = new ArrayList();
            ArraySet = stringArray(set, identify);
            n = ArraySet.Count;
            for (i = 0; i < n; i++)
            {
                ArraySet.RemoveAt(i);
                SubsetResult.Add(stringResult(ArraySet, identify));
                ArraySet.Clear();
                ArraySet = stringArray(set, identify);
            }
            return SubsetResult;
        }

        /// <summary>
        /// 连接候选字符串，字符集合以identify区分
        /// </summary>
        /// <param name="SetA"></param>
        /// <param name="SetB"></param>
        /// <param name="Identify"></param>
        /// <returns></returns>
        private string ConnectionString(string SetA, string SetB, string Identify)
        {
            int i = 0;
            ArrayList StringA = new ArrayList();
            ArrayList StringB = new ArrayList();
            string ResultString = null;
            bool Exit = false;
            StringA = stringArray(SetA, Identify);
            StringB = stringArray(SetB, Identify);
            if (StringA.Count == StringB.Count)
            {
                while ((i < StringA.Count - 1) && !Exit)
                {
                    if (StringA[i].ToString() == StringB[i].ToString())
                    {
                        i++;
                    }
                    else
                    {
                        Exit = true;
                    }
                }
                if (!Exit)
                {
                    if (StringA[StringA.Count - 1] != StringB[StringB.Count - 1])
                    {
                        StringA.Add(StringB[StringB.Count - 1]);
                        ResultString = stringResult(StringA, Identify);
                    }
                }
                else
                {
                    ResultString = null;
                }
            }
            else
            {
                ResultString = null;
            }
            return ResultString;
        }

        /// <summary>
        /// 将数组转换为以identify分隔的字符串
        /// </summary>
        /// <param name="set"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private string stringResult(ArrayList set, string identify)
        {
            string result = "";
            for (int i = 0; i < set.Count; i++)
            {
                result = result + set[i].ToString() + identify;
            }
            result = result.Remove(result.Length - identify.Length);
            return result;
        }

        /// <summary>
        /// 检查checkitems是否均在frequent中?
        /// </summary>
        /// <param name="frequent"></param>
        /// <param name="checkitems"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private bool CheckSubsetinFrequent(ArrayList frequent, ArrayList checkitems, string identify)
        {
            bool result = true;
            int i = 0, j = 0;
            while ((i < checkitems.Count) && (result))
            {
                j = 0;
                result = false;
                while ((j < frequent.Count) && (!result))
                {
                    if (EqualSection(frequent[j].ToString(), checkitems[i].ToString(), identify))
                    {
                        result = true;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (result)
                {
                    i++;
                }
            }
            return result;
        }

        /// <summary>
        /// 求两个字符集合是否相同，字符集合以identify区分
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        private bool EqualSection(string set1, string set2, string identify)
        {
            int i = 0, L = 0, L1 = 0;
            bool equal = true;
            string mid = "", mid1 = "";
            L = LengthChar(set1, identify);
            if (L == LengthChar(set2, identify))
            {
                mid1 = set1;
                i = 0;
                while ((i < L) && (equal))
                {
                    L1 = mid1.IndexOf(identify);
                    if (mid1.Contains(identify))
                    {
                        mid = mid1.Substring(0, L1);
                        if (Contain(mid, set2, identify))
                        {
                            mid1 = mid1.Remove(0, L1 + 1);
                        }
                        else
                        {
                            equal = false;
                        }
                    }
                    else
                    {
                        if (!Contain(mid1, set2, identify))
                        {
                            equal = false;
                        }
                    }
                    i = i + 1;
                }
            }
            else
            {
                equal = false;
            }
            return equal;
        }

        #endregion
    }
}
