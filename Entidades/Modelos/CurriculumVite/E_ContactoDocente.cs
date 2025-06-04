namespace Entidades.Modelos.CurriculumVite
{
    public class E_ContactoDocente
    {
        public int IdContacto { get; set; }
        public int IdDocente { get; set; }
        public int IdTipoContacto { get; set; }
        public string Url { get; set; } = null!;
    }
}
