﻿// <auto-generated />
using System;
using AvansFysioOpdrachtIndividueel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AvansFysioOpdrachtIndividueel.Migrations
{
    [DbContext(typeof(FysioDBContext))]
    partial class FysioDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiagnosisCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IntakeDoneById")
                        .HasColumnType("int");

                    b.Property<int?>("IntakeSupervisedById")
                        .HasColumnType("int");

                    b.Property<string>("IssueDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PlannedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TherapistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IntakeDoneById");

                    b.HasIndex("IntakeSupervisedById");

                    b.HasIndex("TherapistId");

                    b.ToTable("patientDossiers");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PersonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("PatientDossier");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PatientModel", b =>
                {
                    b.HasBaseType("AvansFysioOpdrachtIndividueel.Models.PersonModel");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientDossierId")
                        .HasColumnType("int");

                    b.Property<int>("PatientNumber")
                        .HasColumnType("int");

                    b.HasIndex("PatientDossierId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", "IntakeDoneBy")
                        .WithMany()
                        .HasForeignKey("IntakeDoneById");

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", "IntakeSupervisedBy")
                        .WithMany()
                        .HasForeignKey("IntakeSupervisedById");

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", "Therapist")
                        .WithMany()
                        .HasForeignKey("TherapistId");

                    b.Navigation("IntakeDoneBy");

                    b.Navigation("IntakeSupervisedBy");

                    b.Navigation("Therapist");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PatientModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", null)
                        .WithOne()
                        .HasForeignKey("AvansFysioOpdrachtIndividueel.Models.PatientModel", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", "PatientDossier")
                        .WithMany()
                        .HasForeignKey("PatientDossierId");

                    b.Navigation("PatientDossier");
                });
#pragma warning restore 612, 618
        }
    }
}
