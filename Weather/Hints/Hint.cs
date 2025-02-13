namespace Weather.Hints
{
    public class Hint
    {
        public ValueType ComparableValue { get; set; }
        public CompareType CompareType { get; set; }
        public object CompareToValue { get; set; }
        public string Message { get; set; }
    }
}
