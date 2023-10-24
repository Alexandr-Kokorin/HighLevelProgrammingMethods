using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
    public static class Task3 {

        private static Random random = new Random((int)DateTime.Now.Ticks);
        public static int[] Create(int n) {
            var arr = new int[n];
            for (var i = 0; i < n; i++) {
                arr[i] = random.Next(100);
            }
            return arr;
        }

        public static int[] Addition(ref int[] arr1, ref int[] arr2) {
            if (arr1.Length != arr2.Length) return null;
            var arr = new int[arr1.Length];
            for (var i = 0; i < arr.Length; i++) {
                arr[i] = arr1[i] + arr2[i];
            }
            return arr;
        }
        
        public static int[] Multiplication(ref int[] arr, int n) {
            var res = new int[arr.Length];
            Array.Copy(arr, res, arr.Length);
            for (var i = 0; i < arr.Length; i++) {
                res[i] = arr[i] * n;
            }
            return res;
        }

        public static int[] SearchCommon(ref int[] arr1, ref int[] arr2) {
            var set = new HashSet<int>();
            foreach (var num in arr1) {
                if (arr2.Contains(num)) set.Add(num);
            }
            
            var res = new int[set.Count];
            var index = 0;
            foreach (var num in set) {
                res[index++] = num;
            }
            return res;
        }

        public static void Print(ref int[] arr) {
            foreach (var num in arr) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static int[] Sort(ref int[] arr) {
            var res = new int[arr.Length];
            Array.Copy(arr, res, arr.Length);
            
            for (var i = 0; i < res.Length; i++) {
                for (var j = 0; j < res.Length - 1; j++) {
                    if (res[j] < res[j + 1]) {
                        var temp = res[j + 1];
                        res[j + 1] = res[j];
                        res[j] = temp;
                    }
                }
            }
            return res;
        }

        public static int Min(ref int[] arr) {
            var min = arr[0];
            foreach (var num in arr) {
                min = Math.Min(num, min);
            }
            return min;
        }
        
        public static int Max(ref int[] arr) {
            var max = arr[0];
            foreach (var num in arr) {
                max = Math.Max(num, max);
            }
            return max;
        }
        
        public static float Average(ref int[] arr) {
            var sum = 0f;
            var count = 0;
            foreach (var num in arr) {
                sum += num;
                count++;
            }
            return count == 0 ? sum : sum / count;
        }
    }
}