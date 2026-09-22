public class GarageGate : ILogicValue
{
    private ILogicValue a;
    private ILogicValue b;
    private ILogicValue c;
    public GarageGate (ILogicValue a, ILogicValue b, ILogicValue c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public bool GetValue()
    {
        bool valA = a.GetValue();
        bool valB = b.GetValue();
        bool valC = c.GetValue();

        // Opción 1: Únicamente C (C prendido, A y B en reposo/apagados)
        bool opcion1 = valC && !valA && !valB;

        // Opción 2: A, B y C apretados al mismo tiempo
        bool opcion2 = valA && valB && valC;
        
        return opcion1 || opcion2;
    }
}