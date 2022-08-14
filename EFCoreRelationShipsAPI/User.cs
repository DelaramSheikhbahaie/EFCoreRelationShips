namespace EFCoreRelationShipsAPI
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = String.Empty;
        public List<Characters> Characters { get; set; }
    }
}
