﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace IEL.Estagio.Infra.CrossCutting.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("IELEstagio", throwIfV1Schema: false)
        {
        }

        public IDbSet<Client> Client { get; set; }

        public IDbSet<Claims> Claims { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
