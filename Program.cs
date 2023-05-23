internal class Program {
   public static void Main (string[] args) {

       barco n1 = new barco("TERCERO A", 10, 30000);
       n1.imprimir();

       GPS n2 = new GPS("CAPITAN", "PABLO", "algun-otro-argumento-aqui");
       n2.imprimir();

       capitan n3 = new capitan("CAPITAN");
       n3.Imprimir();
   }
}
