# Тестовое задание Mindbox
Для добавления фигур необходимо наследовать абстрактный класс Shape и переопределить  свойство Area и метод CalculateArea
(новые фигуры должны находится в папке Shapes)
````
public abstract class Shape
{
    public abstract double? Area { get; protected set; }
    public abstract double CalculateArea();
}
````
## Тесты
+ CalculateArea - проверка вычисления площади фигур
+ FiguresIngeritShapeClass - проверка наследование класса Shape
+ FiguresNotExist - проверка не допустимых параметров для фигуры
+ TriangleIsRectangular - проверка прямоугольный ли треугольник
  
![image](https://github.com/user-attachments/assets/d09355b8-d895-4a60-a345-7e04856974db)

