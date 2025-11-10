namespace Lab5 {
    public class Green {
        public int[] Task1(int[,] matrix) {
            int[] answer = null;
            // code here

            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            answer = new int[rows];

            for (var r = 0; r < rows; r += 1) {
                for (var c = 0; c < cols; c += 1) {
                    if (matrix[r, c] < matrix[r, answer[r]]) {
                        answer[r] = c;
                    }
                }
            }

            // end
            return answer;
        }

        public void Task2(int[,] matrix) {
            // code here

            // end
        }
        public void Task3(int[,] matrix, int k) {

            // code here

            // end

        }
        public void Task4(int[,] matrix) {

            // code here

            // end

        }
        public int[,] Task5(int[,] matrix) {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[,] matrix) {

            // code here

            // end

        }
        public int[,] Task7(int[,] matrix, int[] array) {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[,] matrix) {

            // code here

            // end

        }
        public void Task9(int[,] matrix) {

            // code here

            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix) {
            int[] A = null, B = null;

            // code here

            // end

            return (A, B);
        }
        public void Task11(int[,] matrix) {

            // code here

            // end

        }
        public void Task12(int[][] array) {

            // code here

            // end

        }
    }
}