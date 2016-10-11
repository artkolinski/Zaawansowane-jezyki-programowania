import random
import timeit
import time

def scalarProduct(tabA, tabB):
    start = time.time()
    listAB = [a*b for a,b in zip(tabA,tabB)]
    print sum(listAB)
    end = time.time()
    return (end - start)

def rndList(count):
    return [random.uniform(-1000,1000) for r in xrange(count)]

print "data = 100 000, time :"
#print rndList(10)
#print scalarProduct(rndList(5), rndList(3))
print scalarProduct(rndList(100000), rndList(100000))
print "data = 1 000 000, time :"
print scalarProduct(rndList(1000000), rndList(1000000))
print "data = 10 000 000, time :"
print scalarProduct(rndList(10000000), rndList(10000000))
print "data = 10 000 000, time :"
print scalarProduct(rndList(100000000), rndList(100000000))
