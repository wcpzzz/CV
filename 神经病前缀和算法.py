#减去最小前缀
#比较max_sum和“递加-最小前缀”
#牛逼了这个算法我去你大爷
import sys
nums =[1,-2,7,-5,-4,4,555,-66,-7,-8,99,-2,]
min_sum, max_sum = 0, -sys.maxsize
prefix_sum = 0

for num in nums:
    prefix_sum += num
    max_sum = max(max_sum, prefix_sum - min_sum)
    min_sum = min(min_sum, prefix_sum)
print (max_sum)