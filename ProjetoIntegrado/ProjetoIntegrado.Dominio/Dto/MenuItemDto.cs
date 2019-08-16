namespace ProjetoIntegrado.Dominio.Dto
{
    public class MenuItemDto
    {
        public string Label { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Options { get; set; }
        public string FaIcon { get; set; }

        public object Parametros { get; set; }
    }
}
