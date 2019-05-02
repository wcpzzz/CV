a = [1,2,3,4,5,6,7,8,9]
b = [5]
left = 0
right = len(a)
while left+1 < right:
	mid = int((left + right)/2)
	if b[0] < a[mid]:
		right = mid
	else:
		left = mid
if b[0] == a[left]:
	print(left)
elif b[0] == a[right]:
	print(right)
else:
	print("null")