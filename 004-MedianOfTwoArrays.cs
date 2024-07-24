using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;

namespace MedianOfTwoArrays;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // //.. means foreach in x, this case x being an array nums1 and nums2
        // // append all the number in num1 and then num2 to the new list
        // List<int> list = [.. nums1, .. nums2];

        // list.Sort();

        // //if list is odd, return middle number
        // if(list.Count() % 2 == 1) {
        //     return list[list.Count() / 2];
        // }
        // else {
        //     double middle1 = list[(list.Count() / 2) - 1];
        //     double middle2 = list[list.Count() / 2];
        //     return (middle1 + middle2) / 2;
        // }


        int[] A = nums1;
        int[] B = nums2;

        int totalLength = nums1.Length + nums2.Length;
        int halfLength = totalLength / 2;

        //want B to be the longer and A to be shorter
        if(B.Length < A.Length) {
            (int[], int[]) tuple = (B, A);
            A = tuple.Item1;
            B = tuple.Item2;
        }

        int lpointer = 0;
        int rpointer = A.Length - 1;

        while(true) {
            //to get the middle element of A
            int i = (lpointer + rpointer) / 2; 
            // to get the middle element of B
            int j = halfLength - i - 2; //subtract 2 to get rid of the off by 1 in arrays

            int Aleft = (int)(i >= 0 ? A[i] : float.NegativeInfinity);
            int Aright = (int)(i < A.Length ? A[i + 1] : float.PositiveInfinity);
            int Bleft = (int)(i >= 0 ? B[i] : float.NegativeInfinity);
            int Bright = (int)(i < B.Length ? B[j + 1] : float.PositiveInfinity);

            if(Aleft <= Bright && Bleft <= Aright) {
                //odd
                if(totalLength % 2 == 1) {
                    return Math.Min(Aright, Bright);
                }
                //even
                else { 
                    return((Math.Max(Aleft, Bright) + Math.Min(Aright, Bright)) / 2);
                }
            }
            else if(Aleft > Bright) {
                rpointer = i - 1;
            }
            else {
                lpointer = i + 1;
            }

        }




    }
}