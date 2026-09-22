 public class AndGate : ILogicValue
{
    private ILogicValue input1;
    private ILogicValue input2; 
    public AndGate (ILogicValue input1, ILogicValue input2)
    {
        this.input1 = input1;
        this.input2 = input2;
    }
    public bool GetValue()
    {
        return input1.GetValue() && input2.GetValue();
    }
}