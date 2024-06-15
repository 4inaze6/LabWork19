using Task3;

IShape circle = new Circle();

IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle());

IShape greenCircle = new GreenShapeDecorator(new Circle());

Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("C\nircle of red border");
redCircle.Draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();

Console.WriteLine("\nCircle of green border");
greenCircle.Draw();