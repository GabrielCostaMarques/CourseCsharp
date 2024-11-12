namespace CourseCsharp
{
    internal class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Salary { get; set; }


        public void CalculateOldest(Person p1, Person p2)

        {
            int currentYear = DateTime.Now.Year;
            int agep1 = currentYear - p1.Year;
            int agep2 = currentYear - p2.Year;

            if (agep1>agep2)  
            {
                Console.WriteLine("Pessoa mais Velha é: "+p1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais Velha é: " +p2.Name);
            }
        }

        public void CalculateAverageSalary(Person p1, Person p2)
        {
            double employee1 = p1.Salary;
            double employee2 = p2.Salary;

            double handlerHalfSalary = (employee1 + employee2) / 2;

            Console.WriteLine("Média salarial de ambos é de: "+handlerHalfSalary);
        }
    }
}
