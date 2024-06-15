namespace Task4
{
    internal class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Hexa String: {Convert.ToString(subject.GetState(), 16)}");
        }
    }
}
