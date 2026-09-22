public class NotGate : ILogicValue
{
    private ILogicValue input;
    public NotGate (ILogicValue input)
    {
        this.input = input;
    }
    public bool GetValue()
    {
         return !input.GetValue();
    }
}