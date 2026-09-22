using NUnit.Framework;

[TestFixture]
public class GarageGateTests : ILogicValue
{
    public bool GetValue()
    {
        throw new System.NotImplementedException();
    }

    [Test]
    public void GetValueOnlyCOpensTheGate()
    {
        // Arrange
        ILogicValue inputA = new VariableValue(false);
        ILogicValue inputB = new VariableValue(false);
        ILogicValue inputC = new VariableValue(true);

        ILogicValue gate = new GarageGate(inputA, inputB, inputC);

        // Act
        bool result = gate.GetValue();

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }
}