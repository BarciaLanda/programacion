class Tripulante {
    public string nombre1;
    public string nombre;
    public double telefono;
    public double cedula;
    public double edad;
    public double TiempoEspera;

    public Tripulante(string nombre1, string nombre, double telefono, double cedula, double edad, double TiempoEspera) {
        this.nombre1 = nombre1;
        this.nombre = nombre;
        this.telefono = telefono;
        this.cedula = cedula;
        this.edad = edad;
        this.TiempoEspera = TiempoEspera;
    }
}

class marinero : Tripulante {
    private double SueldoBase;
    private double bono;
    private double BonoPescado;
    private double BonoMarisco;
    
    public marinero(string nombre1, string nombre, double telefono, double cedula, double edad, double TiempoEspera, double SueldoBase, double bono, double BonoPescado, double BonoMarisco)
        : base(nombre1, nombre, telefono, cedula, edad, TiempoEspera)
    {
        this.SueldoBase = SueldoBase;
        this.bono = bono;
        this.BonoPescado = BonoPescado;
        this.BonoMarisco = BonoMarisco;
    }

    public void CalcularBono()
    {
        double SueldoTotal = SueldoBase + bono + BonoPescado + BonoMarisco;
        Console.WriteLine("EL SUELDO TOTAL ES: " + SueldoTotal);
    }
}
