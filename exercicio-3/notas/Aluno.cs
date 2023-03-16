namespace Course
{
    class Aluno
    {
        public string Nome;
        public double A;
        public double B;
        public double C;


        public void ResultadoFinal(double a, double b, double c)
        {
            double result = A + B + C;


            if (result > 60.00)
            {
                Console.WriteLine($"NOTA FINAL = {result}");
                Console.WriteLine("APROVADO");
            }
            else
            {
                double restant = 60 - result;
                Console.WriteLine($"NOTA FINAL = {result}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {restant} PONTOS");
            }

        }
    }
}