#求一个游戏里的问题
#题目是这样的：0123，这4个数字记顺序的排列，一共有4*4*4*4=256种可能性
#如果正常遍历，就需要4*256个数字
#但如果把它们写成一行，如00001，就可以同时包含0000和0001的2种可能性
#000010就是三种可能性
#问题就是，求一个算法，能够尽可能求出一个简化的单行排列，以减少遍历数字的个数
import copy
list1=[]
#遍历所有排列可能
for num in range (0,4):
	for num2 in range (0,4):
		for num3 in range (0,4):
			for num4 in range (0,4):
				ltp=(num4,num3,num2,num)
				list1.append(ltp)
print (list1)
pan=(0,0,0)
list2=[0,0,0]
bbbb=4
k=0
#生成新排序后，搜索是否在遍历的排列里，如果是就保存并删去遍历数列中的这个组合，直到遍历为空，程序终止。
while bbbb<1000:
	while k==0:
		for v in range (0,4):
			e=(v,)
			listt=v
			if pan+e in list1:
				list2.append(listt)
				list1.remove(pan+e)
				pan += e
				pan = pan[len(pan)-3:len(pan)]
				bbbb = len(list2)
				k=0
				break
			elif v==3:
				k=1
		else:
			continue
		break
	while k==1:
		for v in range(0,4):
			for vv in range(0,4):
				e=(vv,v)
				listt=[vv,v]
				pann = pan[len(pan)-2:len(pan)]
				if pann+e in list1:
					list2.extend(listt)
					list1.remove(pann+e)
					pan += e
					pan = pan[len(pan)-3:len(pan)]
					bbbb=len(list2)
					k=0
					break
				elif v==3 and vv==3 :
					k=2
#跳出多重循环的方法
			else:
				continue
			break
		else:
			continue
		break
	while k==2:
		for v in range(0,4):
			for vv in range(0,4):
				for vvv in range(0,4):
					e=(vvv,vv,v)
					listt=[vvv,vv,v]
					pannn = pan[len(pan)-1:len(pan)]
					if pannn+e in list1:
						list2.extend(listt)
						list1.remove(pannn+e)
						pan += e
						pan = pan[len(pan)-3:len(pan)]
						bbbb=len(list2)
						k=0
						break
					elif v==3 and vv==3 and vvv==3 :
						k=3	
				else:
					continue
				break
			else:
				continue
			break
		else:
			continue
		break
	while k==3:
		for v in range(0,4):
			for vv in range(0,4):
				for vvv in range(0,4):
					for vvvv in range(0,4):
						e=(vvvv,vvv,vv,v)
						listt=[vvvv,vvv,vv,v]
						if e in list1:
							list2.extend(listt)
							list1.remove(e)
							pan += e
							pan = pan[len(pan)-3:len(pan)]
							bbbb=len(list2)
							k=0
							break
						elif  v==3 and vv==3 and vvv==3 and vvvv==3:
							bbbb=1000
							k=4
					else:
						continue
					break
				else:
					continue
				break
			else:
				continue
			break
		else:
			continue
		break
print (list2)
print (list1)
print (len(list2))
