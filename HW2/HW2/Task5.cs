using System;

namespace HW2 {
    
    public class Task5 {
        
        public static void StartTask(int n) {
            Console.WriteLine("Task5");

            var arr1 = Task3.Create(n * n);
            Task3.Print(ref arr1);
            
            var arr2 = Task3.Create(n * n);
            Task3.Print(ref arr2);
            
            var res = Multiplication(ref arr1, ref arr2);
            Task3.Print(ref res);
        }
        
        public static int[] Multiplication(ref int[] arr1, ref int[] arr2) {
            var res = new int[arr1.Length];
            var size = (int)Math.Sqrt(res.Length);
            for (var i = 0; i < res.Length; i++) {
                var sum = 0;
                for (var j = 0; j < size; j++) {
                    sum += arr1[(i / size) * size + j] * arr2[i % size + size * j];
                }
                res[i] = sum;
            }
            return res;
        }
    }
}