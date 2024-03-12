Coding screen for Pandell. Algorithm implemented utilizes linear run time and space complexity while performing a randomization of array elements, which are the numbers 1-10000 in thise case.

Additionally contains unit test for the resulting array.

Since no specific return format was given, the program prints the numbers to the console, one line at a time.

I did do some research about other solutions to this problem after coding my own approach; the Fisher-Yates algorithm was what I found, which is effectively what I'm doing. However, my approach is a bit more efficient than standard implementations of Fisher-Yates I looked at, as it initializes the array randomly, rather than do a run to initialize, then do the run to randomize, decreasing run time from 2n to n. This is possible due the constraints of the problem, which specify the numbers we know must be used.
