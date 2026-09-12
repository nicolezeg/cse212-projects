public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // First, I need to create an array that will hold all the multiples.
        // The size of the array should be the same as the length provided.
        // Next, I will use a for loop to go through each position of the array.
        // The loop will start at position 0 and continue until it reaches the given length.
        // For each position, I will calculate the multiple by multiplying the
        // starting number by the position plus one.
        // I will store each calculated multiple in the corresponding position
        // of the array.
        // After all the multiples have been added to the array, I will return the array. 

    double[] multiples = new double[length];

    for (int i = 0; i < length; i++)
    {
        multiples[i] = number * (i + 1);
    }

        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // First, get the part of the list that will move to the beginning.
        // This part starts at the position data.Count - amount.
        // Then, get the part of the list that will remain at the end.
        // Clear the original list so the elements can be added back in the new order.
        // Finally, add the two parts back to the original list, starting with the second part.

        List<int> firstPart = data.GetRange(0, data.Count - amount); 
        List<int> secondPart = data.GetRange(data.Count - amount, amount);
        
        data.Clear();
        
        data.AddRange(secondPart); 
        data.AddRange(firstPart);

    }
}
