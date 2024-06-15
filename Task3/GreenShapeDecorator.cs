namespace Task3
{
    internal class GreenShapeDecorator : ShapeDecorator
    {
        public GreenShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetGreenBorder(decoratedShape);
        }

        private void SetGreenBorder(IShape greenDecoratedShape)
        {
            Console.WriteLine("Border Color: Green");
        }
    }
}
