**The Two-Sum Problem**

This is a classic algorithmic interview question. There are many different solution routes, each of which involves a different technique.

#Problem Statement:

You are given an array of n integers and a number k. Determine whether there is a pairof elements in the array that sums to exactly k. For example, given the array [1, 3, 7] andk = 8, the answer is “yes,” but given k = 6 the answer is “no.”

#Possible Solution Routes

#Option 1: Brute force:
One option is to just try all the pairs in the array and see if any of them add up to thenumber  k. Since there are  (Θn2) possible pairs, this takes O(n2) time in the worst-case. This solution uses only O(1) space, since no auxiliary structures are created. This is notconsidered a “good” solution because better options exist, but it's a correct solution.

#Option 2: Hashing:
Another option is to create a hash table of all the elements in the array. You can thenscan over the array and check, for each element A[i], whether there's another elementA[j] in the array where A[j] = k – A[i]. Make sure their solution correctly handles the casewhere there are duplicated elements in the array and doesn't accidentally let you pair anelement with itself.This solution runs in expected time O(n) because n insertions and n lookups in a hash table takes expected time O(n). It uses space O(n). This is considered a “good” solution, there is no clear way to improve on both the time complexity or the space complexity simultaneously.

#Option 3: Sorting and Binary Search:
A third option is to sort the array and use binary search. This is conceptually similar to the hashing approach except that instead of using a hash table, we sort the array elements and use binary search to test if a pair appears. This solution runs in time O(n log n) because it takes O(n log n) time to sort the array using a standard sort and the cost of n binary searches is O(n log n). The space usage depends on the particular sorting algorithm used – quicksort will take O(log n) space, heapsort uses O(1) space. This is considered a “pretty good solution” because it can be sped upa bit in practice using a better sorting algorithm and a different observation about thesorted array (details later).

#Option 4: Sorting and Walking Inward:
A fourth option is to sort the array, then walk two pointers inward from the ends of thearray, at each point looking at their sum. If it's exactly k, then we're done. If it exceeds k,then any sum using the larger element is too large, so we walk that pointer inwards. Ifit's less than k, then any sum using the lower element is too small, so we walk thatpointer inwards.

The runtime of this algorithm depends on the sorting algorithm used. Using a standardsorting algorithm, this takes time O(n log n) due to the cost of sorting. Using somethinglike radix sort, this takes time O(n log U), where U is the largest element of the array, because of the cost of the sort. This will take space O(log n) if you use something like quick-sort or radix sort and O(1) if you use heapsort. This is a “good solution” because in practice it's faster than the sort and binary search approach using a regular sort and is likelyto be faster asymptotically if you use radix sort.
