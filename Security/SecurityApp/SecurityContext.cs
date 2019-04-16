namespace SecurityApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext")
        {
        }

         public virtual DbSet<Visitor> Visitors { get; set; }
    }

}