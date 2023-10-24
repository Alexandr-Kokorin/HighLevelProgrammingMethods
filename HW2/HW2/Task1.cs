using System;

namespace HW2 {
    
    public static class Task1 {

        public static void StartTask(int n, int m, int k) {
            Console.WriteLine("Task1");

            var arr1 = Task3.Create(n);
            Task3.Print(ref arr1);
            
            var arr2 = Task3.Create(m);
            Task3.Print(ref arr2);
            
            Insert(ref arr1, ref arr2, k);
            Task3.Print(ref arr1);
        }

        public static void Insert(ref int[] arr1, ref int[] arr2, int k) {
            Array.Resize(ref arr1, arr1.Length + arr2.Length);
            Array.Copy(arr1, k, arr1, k + arr2.Length, arr1.Length-arr2.Length-k);
            Array.Copy(arr2, 0, arr1, k, arr2.Length);
        }
    }
}