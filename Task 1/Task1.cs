// Instructions: Write a function (use template below to get started) that takes a list of integers and returns a list of only the positive even numbers, doubled. Add at least one error-handling condition

// For submission, commit and push the edited file to Github

// Start the function (Start of Template)

public class Task1 
{
    public static List<int> GetDoubledPositiveEvens(List<object> numberList) 
    {
        // Error-handling: Handle edge case where the list itself is null
        if (numberList == null)
        {
            return new List<int>();
        }

        List<int> finalList = new List<int>();

        // Go through each item in the list
        foreach (var item in numberList) 
        {
            // Error-handling: Check if item is an integer
            if (!(item is int number)) 
            {
                // Skip non-integer values gracefully
                continue; 
            }

            // Check if the number is positive and even
            if (number > 0 && number % 2 == 0) 
            {
                int doubledNumber = number * 2; // Double the number
                finalList.Add(doubledNumber);    // Add it to the final list
            }
        }

        // Return the list of doubled positive even numbers
        return finalList;
    }

    // Example usage
    static void Main() 
    {
        // Fixed typos: changed "-4," to -4 and added a comma after 6
        List<object> myNumbers = new List<object> { 1, 2, "hello", -4, 6, null, 8 };
        
        List<int> result = GetDoubledPositiveEvens(myNumbers);
        Console.WriteLine(string.Join(", ", result)); // Output: 4, 12, 16
    }
}
