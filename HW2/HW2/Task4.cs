using System;

namespace HW2 {
    
    public static class Task4 {
        
        public static void StartTask() {
            Console.WriteLine("Task4");

            var input = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(input[0]);
            var m = Convert.ToInt32(input[1]);

            var matrix = new int[n, m];
            for (var i = 0; i < n; i++) {
                input = Console.ReadLine().Split(' ');
                for (var j = 0; j < m; j++) {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }
            
            var k = Convert.ToInt32(Console.ReadLine());

            var res = FindFreeSeats(ref matrix, k);
            Console.WriteLine(res);
        }

        public static int FindFreeSeats(ref int[,] matrix, int k) {
            for (var i = 0; i < matrix.GetLength(0); i++) {
                var count = 0;
                for (var j = 0; j < matrix.GetLength(1); j++) {
                    if (matrix[i, j] == 1) count = 0;
                    else count++;
                    if (count >= k) return i + 1;
                }
            }
            return 0;
        }
    }
}