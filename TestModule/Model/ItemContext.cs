namespace TestModule.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    class ItemContext : DbContext
    {
        // Your context has been configured to use a 'ItemContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestModule.ItemContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ItemContext' 
        // connection string in the application configuration file.
        public ItemContext()
            : base("name=ItemContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Item> Items { get; set; }
    }

    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}