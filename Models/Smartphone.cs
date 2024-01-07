namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo{get; set;}
        protected string Imei{get; set;}
        protected int Memoria{get; set;}

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
        public void ModeloSmart(string modelo, string imei, int memoria)
        {
            Modelo = modelo.ToUpper();
            Imei = imei.ToUpper();
            Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public void MostrarModelo() 
        {
            Console.WriteLine($"\nSmartPhone\nNúmero {Numero}\nModelo: {Modelo};\nImei: {Imei};\nMemoria: {Memoria}GB");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}