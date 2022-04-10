#! /usr/bin/python3

def divisors(num):
	l = [a for a in range(2,num) is num%a == 0]
	if len(l) == 0:
		return str(num) + " is prime"
	return l

	
