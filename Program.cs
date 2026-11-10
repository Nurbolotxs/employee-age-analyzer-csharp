namespace BigCodingProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] age = new int[n];
            int[] salary = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                age[i] = int.Parse(parts[0]);
                salary[i] = int.Parse(parts[1]);
            }

            int cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                bool exists = false;

                for (int j = 1; j <= i - 1; j++)
                {
                    if (age[j - 1] == age[i - 1])
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    cnt = cnt + 1;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}