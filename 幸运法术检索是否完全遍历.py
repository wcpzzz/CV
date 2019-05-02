#手工写的数字串，检测自己的人工遍历是否出了纰漏
lista=list('0000100020003000110012001300210022002300310032003300101020103011101120113012101220123013101320133020202030211021202130221022202230231023202330301030203031103120313032103220323033103320333011112111311221132113312121213122212231231123212331313132213231332133321122223223323233311131132223333')
print (len(lista))
lista = [ int(x) for x in lista ]
list1=[]
for num in range (0,4):
	for num2 in range (0,4):
		for num3 in range (0,4):
			for num4 in range (0,4):
				ltp=(num,num2,num3,num4)
				list1.append(ltp)
lists=()
listss=()
listsss=()
listssss=()
listt=[]
for i in range(0,len(lista),4):
	lists = tuple(lista[i:i+4])
	listt.append(lists)
listt.pop(-1)
for i in range(1,len(lista),4):
	listss = tuple(lista[i:i+4])
	listt.append(listss)
for i in range(2,len(lista),4):
	listsss = tuple(lista[i:i+4])
	listt.append(listsss)
listt.pop(-1)
for i in range(3,len(lista),4):
	listssss = tuple(lista[i:i+4])
	listt.append(listssss)
listt.pop(-1)
news_ids = []
for id in listt:
    if id not in news_ids:
        news_ids.append(id)
print (news_ids)
list1 = list(set(list1) - set(news_ids))
print (list1)
#事实证明少了（3322），总体还是完美的，结尾加个22就好了