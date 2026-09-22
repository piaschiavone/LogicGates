public class VariableValue : ILogicValue
{
    private bool value;

    public VariableValue(bool value)
    {
        this.value = value;
    }

    public bool GetValue()
    {
        return this.value;
    }
}