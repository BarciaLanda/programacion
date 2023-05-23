class barco{
    
        public string Nombre {get;set;}
        public double CapacidadPasajeros {get;set;}
        public double CapacidadCarga {get;set;}

        public barco (string Nombre, double CapacidadCarga, double CapacidadPasajeros){
                this.Nombre=Nombre;
                this.CapacidadCarga=CapacidadCarga;
                this.CapacidadPasajeros=CapacidadPasajeros;
        }

        public void imprimir (){
                Console.WriteLine("NOMBRE" + Nombre);
                Console.WriteLine("TIPO : PESQUERO");
                Console.WriteLine("CAPACIDAD DE PASAJEROS" + CapacidadPasajeros);
                Console.WriteLine("CAPACIDAD DE CARGA" + CapacidadCarga);
        }

    
}