namespace WebApiGit.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string DataHora { get; set; }

        public Info()
        {
            Id = 0;
            DataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
