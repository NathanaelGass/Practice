using System;
					
public class Pandell
{
	public static void Main()
	{
        //Accomplishes an array randomization with linear run time, linear space complexity
        Random randomNumberGenerator =  new Random();

        int[] randomNumberArray = new int[10000];

        for(int i = 0; i < randomNumberArray.Length; i++){
            
            int currentNumber = i + 1;
            int swapNumberIndex = randomNumberGenerator.Next(randomNumberArray.Length);
            int swapNumber = swapNumberIndex + 1;
            
            if (randomNumberArray[i] != 0) {
                //continue
            } else if(randomNumberArray[swapNumberIndex] == 0){
                randomNumberArray[i] = swapNumber;
                randomNumberArray[swapNumberIndex] = currentNumber;
            } else {
                int numberToSwap = randomNumberArray[swapNumberIndex];
                randomNumberArray[swapNumberIndex] = currentNumber;
                randomNumberArray[i] = numberToSwap;
            }
        }
		
		for(int j = 0; j < randomNumberArray.Length; j++){
			Console.WriteLine(randomNumberArray[j]);
		}

		/*
		//For testing, included to show my process. Feel free to uncomment and run to verify test results.
		//Feel free to add more test cases as well. Does not test randomness, simply duplicates and range/elements.
		
		int[] test1 = {1, 1, 3}; //bad array, duplicate elements
		int[] test2 = {0, 3, 2}; //bad array, element outside bounds (0)
		int[] test3 = {1, 5, 2}; //bad array, element outside bounds (4)
		int[] test4 = {1, 3, 2, 4}; //good array, should pass

		Console.WriteLine(testUnique(randomNumberArray));
		
		Console.WriteLine(testUnique(test1));
		Console.WriteLine(testUnique(test2));
		Console.WriteLine(testUnique(test3));
		Console.WriteLine(testUnique(test4));*/


	}
	
	//Unit Test Method
	public static bool testUnique(int[] arrToTest){
	
		try 
		{
		  	int[] transpileArray = new int[arrToTest.Length] ;
		
			for(int i = 0; i < arrToTest.Length; i++){
				int value = arrToTest[i] - 1;
				if(transpileArray[value] != 0) {
					Console.WriteLine("Duplicate number found");
					return false;
				} else {
					transpileArray[value] = value + 1;
				}
			}

		}
		catch (IndexOutOfRangeException e)
		{
			Console.WriteLine("Random number found outside of number range");
		  	return false;
		}
		
		return true;
	}
	
}