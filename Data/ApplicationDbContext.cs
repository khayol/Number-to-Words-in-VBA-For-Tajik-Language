using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.IndOrg;
using Woorj.Data.Dir;
using Woorj.Services;
using Woorj.Data.Core;
using Woorj.Data.Adm;
using System.Linq;

namespace Woorj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
             //S_Core------------------------------------------------------------------
          
          public DbSet<TypeCategory> TypeCategory { get; set; }
   
          public DbSet<TypeList> TypeList { get; set; }
 
          public DbSet<Status> Status { get; set; }

          public DbSet<SysDataType> SysDataType { get; set; }

          public DbSet<GlobalVariable> GlobalVariable { get; set; }

          public DbSet<Department> Department { get; set; }
            
             //E_Core------------------------------------------------------------------
             //S_Adm------------------------------------------------------------------
              public IQueryable<VGetUserRole> VGetUserRole => Set<VGetUserRole>();    // public DbQuery<vGetUserRole> vGetUserRole{get;set;}
              public DbSet<ApplicationUser> ApplicationUser { get; set; }           //  public DbSet<ApplicationUser> AspNetUsers { get; set; }
              public DbSet<ApplicationRole> ApplicationRole { get; set; }         // public DbSet<ApplicationRole> AspNetRoles { get; set; }          

		      public DbSet<AccessRight> AccessRight { get; set; }
		      public DbSet<AccessRightType> AccessRightType { get; set; }
              public DbSet<RoleAccessRight> RoleAccessRight { get; set; }
              //E_Adm-------------------------------------------------------------
              //------------------------------------------------------------------
		      public DbSet<Country> Country { get; set; }
		      public DbSet<Language> Language { get; set; }
              public DbSet<Localization> Localization { get; set; }
		      public DbSet<Individual> Individual { get; set; }
		 
		      public DbSet<Employee> Employee { get; set; }
		      public DbSet<Contact> Contact { get; set; }
		      public DbSet<Gender> Gender { get; set; }
              //------------------------------------------------------------------
		      public DbSet<Tmp1> Tmp1 { get; set; }
		      public DbSet<Tmp2> Tmp2 { get; set; }
		      public DbSet<Tmp3> Tmp3 { get; set; }
              //------------------------------------------------------------------ 
                /*
                // As you inherit from IdentityDbContext, you don't need to recreate AspNet* DbSet, just add your new table.
                public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
                public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
                public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
                */
              //------------------------------------------------------------------
                protected override void OnModelCreating(ModelBuilder builder)
                {
                base.OnModelCreating(builder);

                    builder.Entity<VGetUserRole>().HasNoKey().ToView("VGetUserRole");

                //S_TypeCategory
                    builder.Entity<TypeCategory>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("TypeCategoryCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<TypeCategory>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR TypeCategoryCode");
                    builder.Entity<TypeCategory>().HasIndex(o => o.Name).IsUnique();
                //E_TypeCategory

                //S_TypeList
                    builder.Entity<TypeList>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("TypeListCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<TypeList>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR TypeListCode");
                    builder.Entity<TypeList>().HasIndex(o => o.Name).IsUnique();
                //E_TypeList

                //S_Status
                    builder.Entity<Status>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("StatusCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Status>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR StatusCode");
                    builder.Entity<Status>().HasIndex(o => o.Name).IsUnique();
                //E_Status

                //S_ysDataType
                    builder.Entity<SysDataType>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("SysDataTypeCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<SysDataType>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR SysDataTypeCode");
                    builder.Entity<SysDataType>().HasIndex(o => o.Name);
                //E_SysDataType

                //S_GlobalVariable
                    builder.Entity<GlobalVariable>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("GlobalVariableCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<GlobalVariable>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR GlobalVariableCode");                   
                    builder.Entity<GlobalVariable>().HasIndex(o => o.KeyWord);           
                //E_GlobalVariable 


                //S_ApplicationRole
                    builder.Entity<ApplicationRole>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("ApplicationRoleCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<ApplicationRole>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR ApplicationRoleCode");                   
                    builder.Entity<ApplicationRole>().HasIndex(o => o.Name);
                    builder.Entity<ApplicationRole>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_ApplicationRole  

                //S_ApplicationRole
                    builder.Entity<ApplicationRole>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("ApplicationRoleCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<ApplicationRole>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR ApplicationRoleCode");                   
                    builder.Entity<ApplicationRole>().HasIndex(o => o.Name);
                    builder.Entity<ApplicationRole>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_ApplicationRole

                //S_AccessRightType
                    builder.Entity<AccessRightType>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("AccessRightTypeCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<AccessRightType>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR AccessRightTypeCode");
                    builder.Entity<AccessRightType>().HasIndex(o => o.Name);
                //E_AccessRightType

                //S_AccessRight
                    builder.Entity<AccessRight>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("AccessRightCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<AccessRight>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR AccessRightCode");
                    builder.Entity<AccessRight>().HasIndex(a => new { a.Name, a.Parent_AccessRightId, a.AccessRightTypeId }).IsUnique();
                //E_AccessRight

                //S_RoleAccessRight
                    builder.Entity<RoleAccessRight>()
                    .HasKey(ra => new { ra.ApplicationRoleId, ra.AccessRightId }); 
                     
                    builder.Entity<RoleAccessRight>()
                    .HasOne(ra => ra.ApplicationRole)
                    .WithMany(b => b.RoleAccessRight)
                    .HasForeignKey(ra => ra.ApplicationRoleId);

                    builder.Entity<RoleAccessRight>()
                    .HasOne(ra => ra.AccessRight)
                    .WithMany(c => c.RoleAccessRight)
                    .HasForeignKey(ra => ra.AccessRightId);
                //E_RoleAccessRight                

                //S_ApplicationUser

                    builder.Entity<ApplicationUser>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("ApplicationUserCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<ApplicationUser>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR ApplicationUserCode");

                    builder.Entity<ApplicationUser>().HasIndex(o => o.FirstName);
                    builder.Entity<ApplicationUser>().HasIndex(o => o.SecondName);
                    builder.Entity<ApplicationUser>().HasIndex(o => o.LastName);
                    builder.Entity<ApplicationUser>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);

                //E_ApplicationUser
                
                        
                //S_Gender
                    builder.Entity<Gender>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("GenderCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Gender>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR GenderCode");
                //E_Gender

                   //S_Contact
                    builder.Entity<Contact>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("ContactCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Contact>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR ContactCode");
                    builder.Entity<Contact>().Property(o => o.CreatedDate)
                   .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_Contact
                
                //S_Country
                    builder.Entity<Country>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("CountryCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Country>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR CountryCode");

                    builder.Entity<Country>().HasIndex(o => o.Alpha2).IsUnique();
                    builder.Entity<Country>().HasIndex(o => o.Alpha3).IsUnique();
                    builder.Entity<Country>().HasIndex(o => o.Iso).IsUnique();

                    builder.Entity<Country>().HasIndex(o => o.Name);
                    builder.Entity<Country>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_Country   

                //S_Language
                    builder.Entity<Language>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("LanguageCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Language>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR LanguageCode");

                    builder.Entity<Language>().HasIndex(o => o.Alpha2).IsUnique();
                    builder.Entity<Language>().HasIndex(o => o.Alpha3).IsUnique();
          
                    builder.Entity<Language>().HasIndex(o => o.Name);
                    builder.Entity<Language>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_Language
        
                //S_Localization
                    builder.Entity<Localization>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("LocalizationCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Localization>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR LocalizationCode");
                    builder.Entity<Localization>().HasIndex(d => new { d.KeyWord, d.LanguageId, d.EntityName }).IsUnique();
                    builder.Entity<Localization>().HasIndex(o => o.Translation);
                    builder.Entity<Localization>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql("getdate()");
                //E_Localization

                //S_Individual
                    builder.Entity<Individual>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("IndividualCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<Individual>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR IndividualCode");

                    builder.Entity<Individual>().HasIndex(o => o.FirstName); // Индексировать для ускорение поиска
                    builder.Entity<Individual>().HasIndex(o => o.SecondName);
                    builder.Entity<Individual>().HasIndex(o => o.LastName);
                    builder.Entity<Individual>().HasIndex(o => o.PassCode);
                    builder.Entity<Individual>().Property(o => o.CreatedDate)
                    .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_Individual
       
          


       
        }
         

              


                /*  Example the make Uniq more thene one field

                //S_Menu_AspMenu

                    builder.Entity<AspMenu>().HasIndex(o => o.Code).IsUnique();
                    builder.HasSequence<int>("AspMenuCode").StartsAt(1000).IncrementsBy(1);
                    builder.Entity<AspMenu>().Property(t => t.Code)
                    .HasDefaultValueSql("NEXT VALUE FOR AspMenuCode");
                    builder.Entity<AspMenu>().HasIndex(d => new { d.MenuId, d.Parent_MenuId, d.MenuFileName, d.MenuURL  }).IsUnique();
                    builder.Entity<AspMenu>().HasIndex(o => o.MenuId);
                    builder.Entity<AspMenu>().HasIndex(o => o.MenuName);
                    builder.Entity<AspMenu>().HasIndex(o => o.Parent_MenuId);
                    builder.Entity<AspMenu>().HasIndex(o => o.MenuFileName);
                    builder.Entity<AspMenu>().HasIndex(o => o.MenuURL);
                    builder.Entity<AspMenu>().Property(o => o.CreatedDate)
                .HasDefaultValueSql(GlobVarStat.date_sys_srv);
                //E_Menu_AspMenu

                */
            

    }
}
