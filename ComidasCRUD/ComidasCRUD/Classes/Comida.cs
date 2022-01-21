namespace ComidasDeliciosas
{
    public class Comida : BaseEntity
    {
        //Definições e Atributos

        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public Sabor Sabor { get; set; }
        public int Validade { get; set; }   // média de dias até estragar

    }
}