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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // create a double with length space
        double[] multiples = new double[length];

        // it should first grab the length of the multiples and loop for each one
        for(var n=0; n<length; n++)
        {
        // only to multiply it by the number you receive + 1 because you started in 0
            multiples[n] = number * (n+1);
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first, we need to check the number of elements that we need to move.
        // for that we will check the amount from the input and create a list with that size.
        List<int> placeHolder = new List<int>(capacity: amount);
        // first we add the data that will go first in the new list to the placeholder
        for(int n=data.Count-amount; n<data.Count; n++)
        {
            placeHolder.Add(data[n]);
        }
        // after that, we set the data inside the new list
        for(int n=0; n<data.Count-amount; n++)
        {
            placeHolder.Add(data[n]);
        }
        // we clean the list
        data.Clear();
        // and add the new order
        data.AddRange(placeHolder);
    
    
    }
}
