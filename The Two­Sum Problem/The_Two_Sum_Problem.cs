//brute force
private bool sumsToTarget(int[] arr, int k)
{
    for (int i = 0; i < arr.length; i++)
    {
        for (int j = i + 1; j < arr.length; j++)
        {
            if(arr[i] + arr[j] == k)
                return true;
        }
    }

    return false;
}

//hasing
private bool sumsToTarget(int[] arr, int k)
{
    HashSet<int> values = new HashSet<int>();

    for (int i = 0; i < arr.length; i++)
    {
        if(values.contains(k - arr[i]))
            return true;

        values.add(arr[i]);
    }

    return false;
}

//sorting and binary search
private bool sumsToTarget(int[] arr, int k)
{
    Arrays.sorte(arr);
    for (int i = 0; i < arr.length; i++)
    {
        int siblingIndex  = Arrays.binarySearch(arr, k - arr[i]);

        if(siblingIndex >= 0)
        {
            if (siblingIndex != i || (i > 0 && arr[i - 1] == arr[i]) || (i < arr.length – 1 && arr[i + 1] == arr[i])) 
            {
                return true;
            }
        }
    }

    return false;
}

//Sorting and Walking Inward
private bool sumsToTarget(int[] arr, int k)
{
    Arrays.sort(arr);
    int lhs = 0;
    int rhs = arr.length – 1;
    
    while (lhs < rhs) 
    {
        int sum = arr[lhs] + arr[rhs];

        if (sum == k) 
            return true;
        else if (sum <  k)
            lhs++;
        else               
            rhs--;
    }

    return false;
}