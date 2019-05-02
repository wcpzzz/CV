class LNode(object):
    #结点初始化函数, p 即模拟所存放的下一个结点的地址
    #为了方便传参, 设置 p 的默认值为 0 
    def __init__(self, data, p=0):
        self.data = data
        self.next = p

class LinkList(object):
    def __init__(self):
        self.head = None

    #链表初始化函数, 方法类似于尾插
    def initList(self, data):
        #创建头结点
        self.head = LNode(data[0])
        p = self.head
        #逐个为 data 内的数据创建结点, 建立链表
        for i in data[1:]:
            node = LNode(i)
            p.next = node
            p = p.next
    #链表判空
    def isEmpty(self):
        if self.head.next == 0:
            print ("Empty List!")
            return 1
        else:
            return 0
    #取链表长度
    def getLength(self):
        if self.isEmpty():
            exit(0)

        p = self.head
        len = 0
        while p:
            len += 1
            p = p.next
        return len
    def traveList(self):
	    if self.isEmpty():
	        exit(0)
	    print ('\rlink list traving result: '),
	    p = self.head
	    while p:
	        print (p.data),
	        p = p.next
data = [1,2,3,4,5]
l = LinkList()
l.initList(data)
l.traveList()