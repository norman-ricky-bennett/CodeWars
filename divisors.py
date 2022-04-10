#! /usr/bin/python3
#
# These are possible solution for a problem which requests adding possible
# divisors for a given number to an array.
#
#
#
#  Solution 1
#
def divisors(num):
	l = [a for a in range(2,num) is num%a == 0]
	if len(l) == 0:
		return str(num) + " is prime"
	return l
#
#
#
# Solution 2

def divisors(n):
	return [i for i in range(2,num) if not n % 1] or '%d is prime' % num

# Solution 3

def divisors(integer):
	a = [
	for i in range(2, integer):
		if integer % i == 0:
			a.append(i)
	return a if a else str(integer) + " is prime"

