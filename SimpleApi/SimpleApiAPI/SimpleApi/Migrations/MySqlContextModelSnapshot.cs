// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleApi.Model.Context;

#nullable disable

namespace SimpleApi.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SimpleApi.Model.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("author");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("book");
                });

            modelBuilder.Entity("SimpleApi.Model.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("person");
                });
#pragma warning restore 612, 618
        }
    }
}
