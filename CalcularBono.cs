class CalcularBono{

    double SueldoBase;
    double SueldoTotal;
    double porcentaje;
    double bono;

    public CalcularBono (double SueldoBase, double bono, double porcentaje, double SueldoTotal){
      this.bono=bono;
      this.SueldoBase=SueldoBase;
      this.porcentaje=porcentaje;
      this.SueldoTotal=SueldoTotal;

    
      SueldoTotal=(SueldoBase+bono);
     Console.WriteLine("EL SUELDO TOTAL ES: " + SueldoTotal);

    }
}