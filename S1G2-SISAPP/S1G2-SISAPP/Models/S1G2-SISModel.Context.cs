﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G2_SISAPP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Departments> Departments1 { get; set; }
        public virtual DbSet<Instructors> Instructors1 { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Students> Students1 { get; set; }
        public virtual DbSet<StudyTerm> StudyTerms { get; set; }
        public virtual DbSet<TeachingAssignments> TeachingAssignments1 { get; set; }
    }
}
