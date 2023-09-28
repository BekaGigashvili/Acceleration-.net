
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
class Program
{
    public static void Main(string[] args)
    {
        
    }

    private static bool isPalindrome(string text){
        if(text.Length == 1){
            return true;
        }
        string s1 = text.Substring(0, text.Length/2);  // first half
        string s2 = "";

        if(text.Length % 2 == 1){   // second half
            s2 = text.Substring(text.Length/2 + 1, text.Length/2);
        }else{
            s2 = text.Substring(text.Length/2, text.Length/2); 
        }

        string s3 = "";
        for(int i = 0; i < s2.Length; i++){    // second half in backwards
            s3 = s2[i] + s3;
        } 

        if(s1.Equals(s3)){
            return true;
        }
        
        return false;
    }

    private static bool isProperly(string sequence){
        int count = 0;
        for(int i = 0; i < sequence.Length; i++){
            Char c = sequence[i];
            if(c == '('){
                count ++;
            }else{
                count --;
            }
        }
        if(count == 0){
            return true;
        }
        
        return false;
    }

    private static int minSplit(int amount) {
		// base case
		if (amount == 0) {
			return 0;
		}
		
		if (amount - 50 >= 0) {
			return 1 + minSplit(amount - 50);
		}
		if (amount - 20 >= 0) {
			return 1 + minSplit(amount - 20);
		}
		if (amount - 10 >= 0) {
			return 1 + minSplit(amount - 10);
		}
		if (amount - 5 >= 0) {
			return 1 + minSplit(amount - 5);
		}

		return 1 + minSplit(amount - 1);
	}

    private static int notContains(int[] array) {
		Dictionary<int, int> data = new Dictionary<int, int>();
		for(int i = 0; i < array.Length; i++) {
			data.Add(i, array[i]);
		}
		for(int i = 0; i < int.MaxValue; i++) {
			if(!data.ContainsValue(i)) {
				return i;
			}
		}
		
		return 0;
	}

    private static int countVariants(int stairsCount) {
		// base cases
		if(stairsCount == 0) {
			return 1;
		}
		if(stairsCount < 0) {
			return 0;
		}
		
		return countVariants(stairsCount - 2) + countVariants(stairsCount - 1);
	}
}
