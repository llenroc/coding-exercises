﻿namespace InterviewPreparation.Exercises
{
    public class MoveZeroesClass
    {
        public void MoveZeroes(int[] nums)
        {
            var fillIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (fillIndex == -1)
                {
                    fillIndex = nums[i] == 0 ? i : -1;
                }
                else if (i != fillIndex && nums[i] != 0)
                {
                    nums[fillIndex] = nums[i];
                    fillIndex++;
                    nums[i] = 0;
                }
            }
        }
    }
}
