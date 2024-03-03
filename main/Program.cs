class Program {
    public static void Main(string[] args) {
        getSum();
    }

    private static void getSum() {
        Console.WriteLine("Введите 1 число.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число.");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Сумма равна " + sum);
    }
}