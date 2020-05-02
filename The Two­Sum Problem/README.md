#The Two-Sum Problem

This is a classic algorithmic interview question. There are many different solution routes, each of which involves a different technique.

Problem Statement:

You are given an array of n integers and a number k. Determine whether there is a pairof elements in the array that sums to exactly k. For example, given the array [1, 3, 7] andk = 8, the answer is “yes,” but given k = 6 the answer is “no.”

Possible Solution Routes

Option 1: Brute force
One option is to just try all the pairs in the array and see if any of them add up to thenumber  k. Since there are  (Θn2) possible pairs, this takes O(n2) time in the worst-case. This solution uses only O(1) space, since no auxiliary structures are created. This is notconsidered a “good” solution because better options exist, but it's a correct solution.

Option 2: Hashing
Another option is to create a hash table of all the elements in the array. You can thenscan over the array and check, for each element A[i], whether there's another elementA[j] in the array where A[j] = k – A[i]. Make sure their solution correctly handles the casewhere there are duplicated elements in the array and doesn't accidentally let you pair anelement with itself.This solution runs in expected time O(n) because n insertions and n lookups in a hash table takes expected time O(n). It uses space O(n). This is considered a “good” solution, there is no clear way to improve on both the time complexity or the space complexity simultaneously.
