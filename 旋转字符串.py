class Solution:
    def rotate(self, nums, k):
        i = k % len(nums)
        nums[:] = nums[-i:]+nums[:-i]
        return nums[:]
a = Solution().rotate([1,2,3,4,5],1)
print (a)