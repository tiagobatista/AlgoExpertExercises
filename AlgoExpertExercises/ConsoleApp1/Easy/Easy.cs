using System.Collections.Generic;

namespace AlgoExpertExercises.Easy
{
    public static class Easy
    {
		/// <summary>
		/// Given two non-empty arrays of integers, write a function that determines whether the second array is a subsequence of the first one.
		/// A subsequence of an array is a set of numbers that aren't necessarily adjacent in the array but that are in the same order as they appear in the array.
		/// For instance, the numbers [1, 3, 4]  form a subsequence of the array [1, 2, 3, 4] , and so do the numbers [2, 4].
		/// Note that a single number in an array and the array itself are both valid subsequences of the array.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="sequence"></param>
		/// <returns>true or false</returns>
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			var sequenceIndex = 0;

            for (int arrayIndex = 0; arrayIndex < array.Count; arrayIndex++)
            {
				if(array[arrayIndex] == sequence[sequenceIndex])
                {
					sequenceIndex++;
				}

				if (sequenceIndex == sequence.Count)
				{
					return true;
				}
			}

			return false;
		}
	}
}
