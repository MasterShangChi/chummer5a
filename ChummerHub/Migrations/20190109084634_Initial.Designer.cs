﻿// <auto-generated />
using System;
using ChummerHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChummerHub.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190109084634_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChummerHub.Data.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("MyRole");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINerUserRight", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanEdit");

                    b.Property<string>("EMail");

                    b.Property<Guid?>("SINnerId");

                    b.Property<Guid?>("SINnerVisibilityId");

                    b.HasKey("Id");

                    b.HasIndex("SINnerId");

                    b.HasIndex("SINnerVisibilityId");

                    b.ToTable("UserRights");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINner", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DownloadUrl");

                    b.Property<string>("GoogleDriveFileId");

                    b.Property<string>("JsonSummary");

                    b.Property<DateTime>("LastChange");

                    b.Property<Guid?>("SINnerMetaDataId");

                    b.Property<Guid>("UploadClientId");

                    b.Property<DateTime?>("UploadDateTime");

                    b.HasKey("Id");

                    b.HasIndex("SINnerMetaDataId");

                    b.ToTable("SINners");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerComment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Downloads");

                    b.Property<string>("Email");

                    b.Property<Guid?>("SINnerId");

                    b.HasKey("Id");

                    b.ToTable("SINnerComments");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerMetaData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("VisibilityId");

                    b.HasKey("Id");

                    b.HasIndex("VisibilityId");

                    b.ToTable("SINnerMetaData");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerVisibility", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Groupname");

                    b.Property<bool>("IsGroupVisible");

                    b.Property<bool>("IsPublic");

                    b.HasKey("Id");

                    b.ToTable("SINnerVisibility");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsUserGenerated");

                    b.Property<Guid?>("ParentTagId");

                    b.Property<Guid?>("SINnerId");

                    b.Property<Guid?>("SINnerMetaDataId");

                    b.Property<Guid?>("TagId");

                    b.Property<string>("TagName");

                    b.Property<int>("TagType");

                    b.Property<string>("TagValue");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SINnerMetaDataId");

                    b.HasIndex("TagId");

                    b.HasIndex("TagName", "TagValue");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.UploadClient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChummerVersion");

                    b.Property<string>("ClientSecret");

                    b.Property<string>("UserEmail");

                    b.HasKey("Id");

                    b.ToTable("UploadClients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Groupname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINerUserRight", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerVisibility")
                        .WithMany("UserRights")
                        .HasForeignKey("SINnerVisibilityId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINner", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerMetaData", "SINnerMetaData")
                        .WithMany()
                        .HasForeignKey("SINnerMetaDataId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerMetaData", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerVisibility", "Visibility")
                        .WithMany()
                        .HasForeignKey("VisibilityId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.Tag", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerMetaData")
                        .WithMany("Tags")
                        .HasForeignKey("SINnerMetaDataId");

                    b.HasOne("ChummerHub.Models.V1.Tag")
                        .WithMany("Tags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ChummerHub.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ChummerHub.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
