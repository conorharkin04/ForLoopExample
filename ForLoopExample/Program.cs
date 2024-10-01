ForLoop();


void ForLoop()
{
    // This program calculates and displays the squares of numbers from 10 to 500

    // Loop from 10 to 500
    for (int number = 10; number <= 500; number++)
    {
        // Calculate the square of the current number
        int square = number * number;

        // Display the result
        Console.WriteLine($"The square of {number} is {square}");
    }

    // Wait for the user to press a key before closing the console window
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
