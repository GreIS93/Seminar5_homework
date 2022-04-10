// Написать программу масштабирования фигуры
// чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Console.Clear();

Console.WriteLine("Задайте координаты вершин фигуры");

int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();

void PrintArray(int[] arr1)
{
    int position = 0;
    while (position < arr1.Length)
    {
        Console.Write($"({arr1[position]}, {arr1[position + 1]}) ");
        position = position + 2;
    }
}

PrintArray(arr);
Console.WriteLine();
Console.WriteLine();

void PrintFigure()
    {
        int x1 = arr[0], y1 = arr[1], x2 = arr[2], y2 = arr[3], x3 = arr[4], y3 = arr[5], x4 = arr[6], y4 = arr[7];

        Console.WriteLine();
        Console.WriteLine();

        Console.Clear();

        Console.SetCursorPosition(x1, y1);
        Console.WriteLine("+");
        Console.SetCursorPosition(x2, y2);
        Console.WriteLine("+");
        Console.SetCursorPosition(x3, y3);
        Console.WriteLine("+");
        Console.SetCursorPosition(x4, y4);
        Console.WriteLine("+");
    }

void ScaleFigure(int[] arr2)
{
    Console.WriteLine("Введите коэффициент масштабирования k");
    int k = int.Parse(Console.ReadLine());
    for (int i = 0; i<arr2.Length; i++)
    {
        arr2[i]=arr2[i]*k;
    }
    
}

PrintFigure();
ScaleFigure(arr);
PrintFigure();
