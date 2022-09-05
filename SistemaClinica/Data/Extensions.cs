namespace SistemaClinica.Data
{
    public static class Extensions
    {
        public static void CreateDb(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<ClinicContext>();
            if (context.Database.EnsureCreated())
            {
                DbInitializer.Initialize(context);
            }
        }
    }
}
