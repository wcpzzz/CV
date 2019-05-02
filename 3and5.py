class ClassName(object):
	"""docstring for ClassName"""
	def q(self, n):
		a = []
		for i in range(1,n):
			if i % 3 != 0 and i % 5 != 0:
				a.append(i)
			if i % 3 == 0:
				a.append("fizz")
			if i % 5 == 0:
				a.append("buzz")
		return a
m = ClassName().q(100)
print (m)