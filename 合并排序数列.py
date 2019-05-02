a = [1,1,2,3,4,5]
b = [1,2,3,4,5,6,6]
list1 = []
i = 0
j = 0
while i < len(a) and j < len(b):
	if a[i] < b[j]:
		list1.append(a[i])
		i += 1
	else:
		list1.append(b[j])
		j += 1
while i < len(a):
	list1.append(a[i])
	i += 1
while j < len(b):
	list1.append(b[j])
	j += 1
print(list1)