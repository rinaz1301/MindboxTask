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
+ FiguresInheritShapeClass - проверка наследование класса Shape
+ FiguresNotExist - проверка недопустимых параметров для фигуры
+ TriangleIsRectangular - проверка прямоугольный ли треугольник
  
![image](https://github.com/user-attachments/assets/d09355b8-d895-4a60-a345-7e04856974db)

## Задание 2
````
﻿SELECT Product.Name, Category.Name FROM Product 
    LEFT JOIN ProductCategory on Product.Id=ProductCategory.ProductId
	LEFT JOIN Category on ProductCategory.CategoryId=Category.Id
```` 

