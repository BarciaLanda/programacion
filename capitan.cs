class Maninero : Tripulante, CalcularBono {
    private double SueldoBase;
    private double bono;
    
    public Maninero(string nombre1, string nombre, double telefono, double cedula, double edad, double TiempoEspera, string sexo, double SueldoBase, double bono, double BonoPescado, double BonoMarisco)
        : base(nombre1, nombre, telefono, cedula, edad, TiempoEspera, sexo, bono, BonoMarisco, BonoPescado)
    {
        this.SueldoBase = SueldoBase;
        this.bono = bono;
    }

    public void CalcularBono()
    {
        double SueldoTotal = SueldoBase + bono;
        Console.WriteLine("EL SUELDO TOTAL ES: " + SueldoTotal);
    }
}
