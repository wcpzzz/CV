numbers = [1,3,5,7,8,2,4,20]

#find total
total=sum(numbers)

#find num
fore=0
for number in numbers:
   if fore<(total-number)/2 :
      fore+=number
   else:
      break

#print answer
if fore == (total-number)/2 :
   print (number)
else :
   print (r'not found')