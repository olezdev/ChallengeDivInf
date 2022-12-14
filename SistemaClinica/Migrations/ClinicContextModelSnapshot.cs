// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaClinica.Data;

#nullable disable

namespace SistemaClinica.Migrations
{
    [DbContext(typeof(ClinicContext))]
    partial class ClinicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsultationPatient", b =>
                {
                    b.Property<int>("ConsultationsId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("ConsultationsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("ConsultationPatient");
                });

            modelBuilder.Entity("SistemaClinica.Entities.Consultation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ConsultingRoomId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAttention")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalPracticeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultingRoomId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicalPracticeId");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("SistemaClinica.Entities.ConsultingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConsultingRooms");
                });

            modelBuilder.Entity("SistemaClinica.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("SistemaClinica.Entities.MedicalPractice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialCost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MedicalPractices");
                });

            modelBuilder.Entity("SistemaClinica.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<int>("HistoryClinic")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ConsultationPatient", b =>
                {
                    b.HasOne("SistemaClinica.Entities.Consultation", null)
                        .WithMany()
                        .HasForeignKey("ConsultationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaClinica.Entities.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaClinica.Entities.Consultation", b =>
                {
                    b.HasOne("SistemaClinica.Entities.ConsultingRoom", "ConsultingRoom")
                        .WithMany()
                        .HasForeignKey("ConsultingRoomId");

                    b.HasOne("SistemaClinica.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("SistemaClinica.Entities.MedicalPractice", "MedicalPractice")
                        .WithMany()
                        .HasForeignKey("MedicalPracticeId");

                    b.Navigation("ConsultingRoom");

                    b.Navigation("Doctor");

                    b.Navigation("MedicalPractice");
                });
#pragma warning restore 612, 618
        }
    }
}
