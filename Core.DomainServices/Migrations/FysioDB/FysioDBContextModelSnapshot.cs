﻿// <auto-generated />
using System;
using AvansFysioOpdrachtIndividueel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.DomainServices.Migrations.FysioDB
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

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommentMadeById")
                        .HasColumnType("int");

                    b.Property<bool>("CommentVisibleForPatient")
                        .HasColumnType("bit");

                    b.Property<int?>("PatientDossierModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfCreation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CommentMadeById");

                    b.HasIndex("PatientDossierModelId");

                    b.ToTable("CommentModel");
                });

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

                    b.Property<int?>("IntakeDoneById")
                        .HasColumnType("int");

                    b.Property<int?>("IntakeSupervisedById")
                        .HasColumnType("int");

                    b.Property<string>("IssueDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PlannedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TherapistId")
                        .HasColumnType("int");

                    b.Property<int?>("TreatmentPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IntakeDoneById");

                    b.HasIndex("IntakeSupervisedById");

                    b.HasIndex("TherapistId");

                    b.HasIndex("TreatmentPlanId");

                    b.ToTable("PatientDossierModel");
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

                    b.ToTable("Person");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.TreatmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Complications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientDossierModelId")
                        .HasColumnType("int");

                    b.Property<int?>("TreatmentDoneById")
                        .HasColumnType("int");

                    b.Property<bool>("TreatmentRoomOrTrainingRoom")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TreatmentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VektisType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientDossierModelId");

                    b.HasIndex("TreatmentDoneById");

                    b.ToTable("TreatmentModel");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.TreatmentPlanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfTreaments")
                        .HasColumnType("int");

                    b.Property<string>("TimeOfTreatment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TreatmentPlanModel");
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

                    b.Property<int>("TeacherOrStudentNumber")
                        .HasColumnType("int");

                    b.HasIndex("PatientDossierId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.StudentModel", b =>
                {
                    b.HasBaseType("AvansFysioOpdrachtIndividueel.Models.PersonModel");

                    b.Property<int>("StudentNumber")
                        .HasColumnType("int");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.TeacherModel", b =>
                {
                    b.HasBaseType("AvansFysioOpdrachtIndividueel.Models.PersonModel");

                    b.Property<int>("BIGNumber")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelNumber")
                        .HasColumnType("int");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.CommentModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", "CommentMadeBy")
                        .WithMany()
                        .HasForeignKey("CommentMadeById");

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", null)
                        .WithMany("ExtraComments")
                        .HasForeignKey("PatientDossierModelId");

                    b.Navigation("CommentMadeBy");
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

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.TreatmentPlanModel", "TreatmentPlan")
                        .WithMany()
                        .HasForeignKey("TreatmentPlanId");

                    b.Navigation("IntakeDoneBy");

                    b.Navigation("IntakeSupervisedBy");

                    b.Navigation("Therapist");

                    b.Navigation("TreatmentPlan");
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.TreatmentModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", null)
                        .WithMany("Treatments")
                        .HasForeignKey("PatientDossierModelId");

                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", "TreatmentDoneBy")
                        .WithMany()
                        .HasForeignKey("TreatmentDoneById");

                    b.Navigation("TreatmentDoneBy");
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

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.StudentModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", null)
                        .WithOne()
                        .HasForeignKey("AvansFysioOpdrachtIndividueel.Models.StudentModel", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.TeacherModel", b =>
                {
                    b.HasOne("AvansFysioOpdrachtIndividueel.Models.PersonModel", null)
                        .WithOne()
                        .HasForeignKey("AvansFysioOpdrachtIndividueel.Models.TeacherModel", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvansFysioOpdrachtIndividueel.Models.PatientDossierModel", b =>
                {
                    b.Navigation("ExtraComments");

                    b.Navigation("Treatments");
                });
#pragma warning restore 612, 618
        }
    }
}
