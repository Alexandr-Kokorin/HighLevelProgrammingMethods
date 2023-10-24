using System;

namespace HW2 {
    
    public static class Task2 {
        
        public static void StartTask(int n) {
            Console.WriteLine("Task2");

            var arr = Task3.Create(n);
            Task3.Print(ref arr);
            
            Revers(ref arr);
            Task3.Print(ref arr);
        }

        public static void Revers(ref int[] arr) {
            Array.Reverse(arr);
        }
    }
}