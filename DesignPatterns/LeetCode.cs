using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Xml.Linq;
using System.Data;

namespace DesignPatterns
{
    internal class LeetCode
    {
        #region LeetCode 88 Merge Sort Array 
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //[1,3,5,0,0,0,0]
            //[2.2.5]

            int mIndex = m - 1; 
            int nIndex = n - 1;
            int rIndex = (m+n)-1;
            int tempVariable = 0; 

            while (nIndex >=0)
            {
                if (nums1[mIndex] >nums2[nIndex]  )
                {
                    nums1[rIndex] = nums1[mIndex];
                    mIndex--;
                    //mIndex--;
                  
                }
                else
                {

                    nums1[rIndex] = nums2[nIndex];
                   

                    nIndex--;
                  
                }
                rIndex--;
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i] + ",");

            }
        }

        #endregion

        #region LeetCode 26 Remove Duplicate
        internal int  RemoveDuplicate(int[] nums)
        {
            int swapPosition = 1;
            int indexPos = 1;

            while (indexPos< nums.Length)
            {
                if (nums[indexPos] != nums[indexPos-1])
                {
                   
                    nums[swapPosition] = nums[indexPos];
                    swapPosition++;
                }
               
               indexPos++;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            return swapPosition;
        }
        #endregion

        #region LeetCode 27 Remove Element

        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

        ///Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

        ///Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
        ///Return k.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        internal void RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int lastElement = nums.Length-1;
            int temp = 0;
            int element = nums.Length -1 ;
            while (element>=0) {
                if (nums[element] == val )
                {
                    temp = nums[lastElement];
                    nums[lastElement] = nums[element];
                    nums[element] = temp;
                    lastElement--;
                    

                }
                else
                {
                    k++;
                }
                element--;
                 
              
            }

            Console.WriteLine("k" + k);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        
        }

        #endregion



        #region LeetCode 80 Remove More than two
        internal int RemoveDuplicateV2(int[] nums)
        {
            int i = 1; 
            int j = 1;
            int repetition = 1;

            while (i < nums.Length)
            {
                if (nums[i] == nums[i-1])
                {
                    
                    repetition++;
                   
                   
                   

                }
                else
                {
                    repetition = 1;
                    

                    //repetition++;
                    
                   
                }
                if (repetition <= 2)
                {
                    nums[j] = nums[i];
                    j++;
                }
                i++;

            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count is" +  j);
            return j;


        }

        #endregion


        #region Majority Element

        internal int MajorityElement(int[] nums) 
        {
            Dictionary<int, int> kv = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (kv.ContainsKey(item))
                {
                    kv[item] = kv[item]+1;
                }
                else
                {
                    kv.Add(item, 1);
                }
            }

          return  kv.FirstOrDefault(e => e.Value > (nums.Length) / 2).Key;
        }

        internal void RotateByK(int[] nums, int k)
        {
            //reverse the array 
            k= k % nums.Length;
             ReverseKElements(nums, 0, nums.Length-1);

            //reverse the first k elements 
            ReverseKElements(nums, 0, k - 1);

            ReverseKElements(nums,k, nums.Length - 1);

            
        }

        internal void ReverseKElements(int[] num , int start, int end ) 
        {
            //int temp = 0; 
            while (start < end)
            {
                (num[start], num[end]) = (num[end], num[start]);   

                start++; end--;
            }

        }

        #endregion


    }
}
