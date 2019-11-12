﻿// <auto-generated />
using System;
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace bd_backend.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("App.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("App.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PWZNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("App.ExaminationDictionary", b =>
                {
                    b.Property<int>("ExaminationDictionaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ExaminationDictionaryId");

                    b.ToTable("ExaminationsDictionary");
                });

            modelBuilder.Entity("App.LaboratoryExamination", b =>
                {
                    b.Property<int>("LaboratoryExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ApprovalRejectionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorComment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExaminationDictionaryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LaboratoryManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LaboratoryWorkerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MenagerComment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientVisitId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LaboratoryExaminationId");

                    b.HasIndex("ExaminationDictionaryId");

                    b.HasIndex("LaboratoryManagerId");

                    b.HasIndex("LaboratoryWorkerId");

                    b.HasIndex("PatientVisitId");

                    b.ToTable("LaboratoryExaminations");
                });

            modelBuilder.Entity("App.LaboratoryManager", b =>
                {
                    b.Property<int>("LaboratoryManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LaboratoryManagerId");

                    b.ToTable("LaboratoryManagers");
                });

            modelBuilder.Entity("App.LaboratoryWorker", b =>
                {
                    b.Property<int>("LaboratoryWorkerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LaboratoryWorkerId");

                    b.ToTable("LaboratoryWorkers");
                });

            modelBuilder.Entity("App.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("App.PatientVisit", b =>
                {
                    b.Property<int>("PatientVisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReceptionistId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PatientVisitId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("PatientVisits");
                });

            modelBuilder.Entity("App.PhysicalExamination", b =>
                {
                    b.Property<int>("PhysicalExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExaminationDictionaryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientVisitId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PhysicalExaminationId");

                    b.HasIndex("ExaminationDictionaryId");

                    b.HasIndex("PatientVisitId");

                    b.ToTable("PhysicalExaminations");
                });

            modelBuilder.Entity("App.Receptionist", b =>
                {
                    b.Property<int>("ReceptionistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ReceptionistId");

                    b.ToTable("Receptionists");
                });

            modelBuilder.Entity("App.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DisabledTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("App.LaboratoryExamination", b =>
                {
                    b.HasOne("App.ExaminationDictionary", "ExaminationDictionary")
                        .WithMany("LaboratoryExaminations")
                        .HasForeignKey("ExaminationDictionaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.LaboratoryManager", "LaboratoryManager")
                        .WithMany("CheckedExaminations")
                        .HasForeignKey("LaboratoryManagerId");

                    b.HasOne("App.LaboratoryWorker", "LaboratoryWorker")
                        .WithMany("PerformedExaminations")
                        .HasForeignKey("LaboratoryWorkerId");

                    b.HasOne("App.PatientVisit", "PatientVisit")
                        .WithMany("OrderedExaminations")
                        .HasForeignKey("PatientVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.PatientVisit", b =>
                {
                    b.HasOne("App.Doctor", "Doctor")
                        .WithMany("PerformedVisits")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Patient", "Patient")
                        .WithMany("PatientVisits")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Receptionist", "Receptionist")
                        .WithMany("RegisteredVisits")
                        .HasForeignKey("ReceptionistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.PhysicalExamination", b =>
                {
                    b.HasOne("App.ExaminationDictionary", "ExaminationDictionary")
                        .WithMany("PhysicalExaminations")
                        .HasForeignKey("ExaminationDictionaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.PatientVisit", "PatientVisit")
                        .WithMany()
                        .HasForeignKey("PatientVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
