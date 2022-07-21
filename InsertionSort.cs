Random r = new Random();
int[] arr = new int[10];

//Creates the array of random numbers between 1 and 99
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(1, 100);
}

//Prints the unsorted array
Console.Write("The unsorted array: ");
foreach (int j in arr)
{
    Console.Write($"{j} ");
}
Console.WriteLine();

//Calls the Insertion Sort method
InsertionSort(arr);

//The Insertion Sort method
static void InsertionSort(int[] a)
{
    //Loops through each element in a, aside from the 1st element
    for (int i = 1; i < a.Length; i++)
    {
        int val = a[i];

        //Loops through each element before the ith element
        for (int j = i - 1; j >= 0; j--)
        {
            //Checks to see if val is less than the element at the jth position; if so, swap the values
            if (val < a[j])
            {
                int tmp = a[j];
                a[j] = val;
                a[j + 1] = tmp;
            }
        }

        //Prints the array after the pass, separating the sorted and the unsorted sections
        Console.Write("After this pass: ");

        for (int k = 0; k < a.Length; k++)
        {
            //Splits the sorted and unsorted portions of the array
            if (k == i)
            {
                Console.Write($"{a[k]} --");
            }
            else
            {
                Console.Write($"{a[k]} ");
            }
        }
        Console.WriteLine();
    }//end outer for loop
}//end InsertionSort method