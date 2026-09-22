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
        ILogicValue inputA = new LogicConstant(false);
        ILogicValue inputB = new LogicConstant(false);
        ILogicValue inputC = new LogicConstant(true);

        ILogicValue gate = new GarageGate(inputA, inputB, inputC);

        // Act
        bool result = gate.GetValue();

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }
}