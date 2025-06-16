namespace ApiLaboratorial.Models
{
    public class TabelaTeste
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = null!;
        public double Temperatura { get; set; }
        public double Bateria { get; set; }
        
    }
}
