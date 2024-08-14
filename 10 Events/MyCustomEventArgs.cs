namespace _10_Events
{
    public class MyCustomEventArgs 
    {
        public string Message { get; set; }
        public int Value { get; set; }

        public MyCustomEventArgs(string message, int value)
        {
            Message = message;
            Value = value;
        }
    }
}
