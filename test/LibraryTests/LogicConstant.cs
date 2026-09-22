public class LogicConstant : ILogicValue
{
    private bool value;

    public LogicConstant(bool value)
    {
        this.value = value;
    }

    public bool GetValue()
    {
        return this.value;
    }
}