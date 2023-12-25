﻿// <auto-generated />
using System;
using EasyMicroservices.AuthenticationsMicroservice.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyMicroservices.AuthenticationsMicroservice.Migrations
{
    [DbContext(typeof(AuthenticationsContext))]
    partial class AuthenticationsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.PersonalAccessTokenEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.HasIndex("UserId");

                    b.ToTable("PersonalAccessTokens");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(3061),
                            IsDeleted = false,
                            UserId = 1L,
                            Value = "ownerpat"
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2492),
                            IsDeleted = false,
                            Name = "Owner"
                        },
                        new
                        {
                            Id = 2L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2506),
                            IsDeleted = false,
                            Name = "SystemAdmin"
                        },
                        new
                        {
                            Id = 3L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2507),
                            IsDeleted = false,
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            Id = 4L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2507),
                            IsDeleted = false,
                            Name = "HardWriter"
                        },
                        new
                        {
                            Id = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2508),
                            IsDeleted = false,
                            Name = "Moderator"
                        },
                        new
                        {
                            Id = 6L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2508),
                            IsDeleted = false,
                            Name = "HardReader"
                        },
                        new
                        {
                            Id = 7L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2508),
                            IsDeleted = false,
                            Name = "Operator"
                        },
                        new
                        {
                            Id = 8L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2509),
                            IsDeleted = false,
                            Name = "EndUser"
                        },
                        new
                        {
                            Id = 9L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2509),
                            IsDeleted = false,
                            Name = "SoftWriter"
                        },
                        new
                        {
                            Id = 10L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2509),
                            IsDeleted = false,
                            Name = "SoftReader"
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleParentChildEntity", b =>
                {
                    b.Property<long>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long>("ChildId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("ParentId", "ChildId");

                    b.HasIndex("ChildId");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("RoleParentChildren");

                    b.HasData(
                        new
                        {
                            ParentId = 2L,
                            ChildId = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2871),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 3L,
                            ChildId = 2L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2872),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 4L,
                            ChildId = 2L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2872),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 5L,
                            ChildId = 3L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2873),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 6L,
                            ChildId = 3L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2873),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 7L,
                            ChildId = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2874),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 8L,
                            ChildId = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2874),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 9L,
                            ChildId = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2874),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 10L,
                            ChildId = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2875),
                            IsDeleted = false
                        },
                        new
                        {
                            ParentId = 9L,
                            ChildId = 2L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2875),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleServicePermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServicePermissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("RoleId");

                    b.HasIndex("ServicePermissionId");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("RoleServicePermissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2991),
                            IsDeleted = false,
                            RoleId = 1L,
                            ServicePermissionId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2991),
                            IsDeleted = false,
                            RoleId = 10L,
                            ServicePermissionId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2991),
                            IsDeleted = false,
                            RoleId = 10L,
                            ServicePermissionId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2992),
                            IsDeleted = false,
                            RoleId = 10L,
                            ServicePermissionId = 4L
                        },
                        new
                        {
                            Id = 5L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2992),
                            IsDeleted = false,
                            RoleId = 6L,
                            ServicePermissionId = 5L
                        },
                        new
                        {
                            Id = 6L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2993),
                            IsDeleted = false,
                            RoleId = 6L,
                            ServicePermissionId = 6L
                        },
                        new
                        {
                            Id = 7L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2993),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 7L
                        },
                        new
                        {
                            Id = 8L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2993),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 8L
                        },
                        new
                        {
                            Id = 9L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2994),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 9L
                        },
                        new
                        {
                            Id = 10L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2994),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 10L
                        },
                        new
                        {
                            Id = 11L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2994),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 11L
                        },
                        new
                        {
                            Id = 12L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2995),
                            IsDeleted = false,
                            RoleId = 9L,
                            ServicePermissionId = 12L
                        },
                        new
                        {
                            Id = 13L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2995),
                            IsDeleted = false,
                            RoleId = 4L,
                            ServicePermissionId = 13L
                        },
                        new
                        {
                            Id = 14L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2995),
                            IsDeleted = false,
                            RoleId = 4L,
                            ServicePermissionId = 14L
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.ServicePermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte>("AccessType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MethodName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MicroserviceName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("MethodName");

                    b.HasIndex("MicroserviceName");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("ServiceName");

                    b.HasIndex("UniqueIdentity");

                    b.HasIndex("MicroserviceName", "ServiceName", "MethodName")
                        .IsUnique()
                        .HasFilter("[MicroserviceName] IS NOT NULL AND [ServiceName] IS NOT NULL AND [MethodName] IS NOT NULL");

                    b.ToTable("ServicePermissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2915),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2915),
                            IsDeleted = false,
                            MethodName = "GetById"
                        },
                        new
                        {
                            Id = 3L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2916),
                            IsDeleted = false,
                            MethodName = "Filter"
                        },
                        new
                        {
                            Id = 4L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2916),
                            IsDeleted = false,
                            MethodName = "GetByUniqueIdentity"
                        },
                        new
                        {
                            Id = 5L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2917),
                            IsDeleted = false,
                            MethodName = "GetAllByUniqueIdentity"
                        },
                        new
                        {
                            Id = 6L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2917),
                            IsDeleted = false,
                            MethodName = "GetAll"
                        },
                        new
                        {
                            Id = 7L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2917),
                            IsDeleted = false,
                            MethodName = "Add"
                        },
                        new
                        {
                            Id = 8L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2918),
                            IsDeleted = false,
                            MethodName = "Update"
                        },
                        new
                        {
                            Id = 9L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2918),
                            IsDeleted = false,
                            MethodName = "SoftDeleteById"
                        },
                        new
                        {
                            Id = 10L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2918),
                            IsDeleted = false,
                            MethodName = "SoftDeleteBulkByIds"
                        },
                        new
                        {
                            Id = 11L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2919),
                            IsDeleted = false,
                            MethodName = "AddBulk"
                        },
                        new
                        {
                            Id = 12L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2919),
                            IsDeleted = false,
                            MethodName = "UpdateBulk"
                        },
                        new
                        {
                            Id = 13L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2919),
                            IsDeleted = false,
                            MethodName = "HardDeleteById"
                        },
                        new
                        {
                            Id = 14L,
                            AccessType = (byte)6,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(2920),
                            IsDeleted = false,
                            MethodName = "HardDeleteBulkByIds"
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(3022),
                            IsDeleted = false,
                            IsVerified = true,
                            UserName = "Owner"
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserRoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("RoleId");

                    b.HasIndex("UniqueIdentity");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDateTime = new DateTime(2023, 12, 4, 9, 38, 29, 68, DateTimeKind.Local).AddTicks(3040),
                            IsDeleted = false,
                            RoleId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.PersonalAccessTokenEntity", b =>
                {
                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserEntity", "User")
                        .WithMany("PersonalAccessTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleParentChildEntity", b =>
                {
                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", "Child")
                        .WithMany("Children")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", "Parent")
                        .WithMany("Parents")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleServicePermissionEntity", b =>
                {
                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", "Role")
                        .WithMany("RoleServicePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.ServicePermissionEntity", "ServicePermission")
                        .WithMany("RoleServicePermissions")
                        .HasForeignKey("ServicePermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("ServicePermission");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserEntity", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.RoleEntity", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Parents");

                    b.Navigation("RoleServicePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.ServicePermissionEntity", b =>
                {
                    b.Navigation("RoleServicePermissions");
                });

            modelBuilder.Entity("EasyMicroservices.AuthenticationsMicroservice.Database.Entities.UserEntity", b =>
                {
                    b.Navigation("PersonalAccessTokens");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
