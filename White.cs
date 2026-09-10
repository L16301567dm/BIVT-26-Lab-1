namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            d = double.Parse(Console.ReadLine());
            if (d > 4) {
                answer = true;
            }
            // end


            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b) {
                answer = a;
            }
            else {
                answer = b;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            d = double.Parse(Console.ReadLine());
            f = double.Parse(Console.ReadLine());
            if (d < 0) {d *= -1;}
            if (f < 0) {f *= -1;}
            answer = Math.Min(d, f);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            x = double.Parse(Console.ReadLine());
            if (Math.Abs(x) <= 1) { answer = x; }
            else {answer = 1;}
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -4)) { answer = true; }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            n = int.Parse(Console.ReadLine());
            int s = (int)Math.Pow(n, 2);
            if (s - n > n * 2)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }
            
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
    }
}