﻿

namespace Axity.DataAccessEntity.Entities.Data.Constraint
{
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;
    public static class UserConstraint
    {
        public static void Init(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().Property(e => e.Mail).IsUnicode(true);
            modelBuilder.Entity<UserModel>().Property(e => e.Phone).IsUnicode(true);
            modelBuilder.Entity<UserRolModel>().HasKey(e => new { e.UserId, e.RolId });
        }
    }
}
