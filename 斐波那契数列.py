# -*- coding: UTF-8 -*-
 
# Filename : test.py
# author by : www.runoob.com
 
# Python 斐波那契数列实现
 
# 获取用户输入数据
nterms = int(input("你需要几项？"))
 
# 第一和第二项
n1 = 0
n2 = 1
# 判断输入的值是否合法
if nterms <= 0:
   print("请输入一个正整数。")
elif nterms == 1:
   print("斐波那契数列：")
   print(n1)
else:
   print("斐波那契数列：")
   print(n1,",",n2,end=" , ")
   for count in range (2,nterms):
       nth = n1 + n2
       print(nth,end=" , ")
       # 更新值
       n1 = n2
       n2 = nth
       count += 1