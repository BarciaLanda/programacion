class JefeFlota : Tripulante, CalcularBono {

    public JefeFlota(string nombre1, string nombre, double telefono, double cedula, double edad, double TiempoEspera, string sexo, double SueldoBase, double bono, double BonoPescado, double BonoMarisco) : base(nombre1, nombre, telefono, cedula, edad, TiempoEspera, sexo, bono, BonoMarisco, BonoPescado)
    {
    }

    public void CalcularBono(double sueldoBase, double bono)
    {
        double SueldoTotal;
        SueldoTotal = (sueldoBase + bono);
        Console.WriteLine("EL SUELDO TOTAL ES: " + SueldoTotal);
    }

}
