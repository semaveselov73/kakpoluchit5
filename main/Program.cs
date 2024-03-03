class Program {
    public static void Main(string[] args) {
        getSum();
    }

    private static void getSum() {
        Console.WriteLine("Введите числа.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Сумма равна " + sum);
    }
}