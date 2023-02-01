double Input(string var_name)
{
	Console.Write($"Введите {var_name}: ");
	return Convert.ToDouble(Console.ReadLine());
}

Console.Clear();
double x1 = Input("x1");;
double y1 = Input("y1");;
double x2 = Input("x2");;
double y2 = Input("y2");;
double x3 = Input("x3");;
double y3 = Input("y3");;
Console.WriteLine($"Площадь треугольника: {(x1*(y3-y2)+x2*(y1-y3)+x3*(y2-y1))/2}");
