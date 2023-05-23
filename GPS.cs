class GPS{
 
        public double CordenadasX{get;set;}
        public double CordenadasY{get;set;}

        public double DiasTripulado{get;set;}

        public double FechaRegistro{get;set;}

        public double HoraRegistro{get;set;}

        public GPS (double CordenadasX, double CordenadasY, double FechaRegistro, double DiasTripulado, double HoraRegistro){
           this.CordenadasX=CordenadasX;
           this.CordenadasY=CordenadasY;
           this.FechaRegistro=FechaRegistro;
           this.DiasTripulado=DiasTripulado;
           this.FechaRegistro=FechaRegistro;
        }

        public void imprimir(){
                Console.WriteLine("COORDENADAS X" + CordenadasX);
                Console.WriteLine("COORDENADAS Y" + CordenadasY);
                Console.WriteLine("DIAS TRIPULADOS" + DiasTripulado);
                Console.WriteLine("FECHA DE REGISTRO" + FechaRegistro);                
                Console.WriteLine("HORA DE REGISTRO" + HoraRegistro);


        }

    
}

  
