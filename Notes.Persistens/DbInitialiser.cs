namespace Notes.Persistens
{
    public class DbInitialiser
    {
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
