﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace back_end.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241109155722_ConfigureSubscriptionIdAutoGenerated")]
    partial class ConfigureSubscriptionIdAutoGenerated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Thinking, Fast and Slow",
                            PurchasePrice = 14.99m,
                            Text = "An exploration of the two modes of thought: fast, intuitive thinking, and slower, logical reasoning by Nobel laureate Daniel Kahneman."
                        },
                        new
                        {
                            Id = 2,
                            Name = "Good to Great: Why Some Companies Make the Leap... and Others Don't",
                            PurchasePrice = 15.99m,
                            Text = "Jim Collins investigates why some companies succeed and others fail, providing insights into building long-lasting greatness."
                        },
                        new
                        {
                            Id = 3,
                            Name = "The Lean Startup: How Today's Entrepreneurs Use Continuous Innovation to Create Radically Successful Businesses",
                            PurchasePrice = 16.99m,
                            Text = "Eric Ries shares a scientific approach to creating and managing successful startups in an age when companies need to innovate more than ever."
                        },
                        new
                        {
                            Id = 4,
                            Name = "How to Win Friends and Influence People",
                            PurchasePrice = 10.99m,
                            Text = "Dale Carnegie’s timeless principles on building relationships and enhancing influence, first published in 1936 and still relevant today."
                        },
                        new
                        {
                            Id = 5,
                            Name = "Zero to One: Notes on Startups, or How to Build the Future",
                            PurchasePrice = 17.99m,
                            Text = "Peter Thiel explores how to create new, innovative businesses that go beyond mere competition to carve out unique niches."
                        },
                        new
                        {
                            Id = 6,
                            Name = "The 7 Habits of Highly Effective People: Powerful Lessons in Personal Change",
                            PurchasePrice = 12.99m,
                            Text = "Stephen Covey presents timeless principles that have helped millions find personal and professional effectiveness."
                        },
                        new
                        {
                            Id = 7,
                            Name = "Principles: Life and Work",
                            PurchasePrice = 19.99m,
                            Text = "Ray Dalio, one of the world's most successful investors, shares the principles he has developed over his career to achieve success."
                        },
                        new
                        {
                            Id = 8,
                            Name = "Start with Why: How Great Leaders Inspire Everyone to Take Action",
                            PurchasePrice = 13.99m,
                            Text = "Simon Sinek’s guide to inspiring others by focusing on purpose, rooted in his concept of the Golden Circle."
                        },
                        new
                        {
                            Id = 9,
                            Name = "The Innovator's Dilemma: When New Technologies Cause Great Firms to Fail",
                            PurchasePrice = 18.99m,
                            Text = "Clayton Christensen’s groundbreaking book on how disruptive innovation affects industries and businesses."
                        },
                        new
                        {
                            Id = 10,
                            Name = "Drive: The Surprising Truth About What Motivates Us",
                            PurchasePrice = 11.99m,
                            Text = "Daniel H. Pink examines the science behind motivation, revealing surprising insights on what drives us."
                        },
                        new
                        {
                            Id = 11,
                            Name = "To Kill a Mockingbird",
                            PurchasePrice = 9.99m,
                            Text = "Harper Lee's classic novel that explores racial injustice and moral growth in the American South."
                        },
                        new
                        {
                            Id = 12,
                            Name = "1984",
                            PurchasePrice = 8.99m,
                            Text = "George Orwell's dystopian novel that delves into the dangers of totalitarianism and extreme political ideology."
                        },
                        new
                        {
                            Id = 13,
                            Name = "Pride and Prejudice",
                            PurchasePrice = 7.99m,
                            Text = "Jane Austen's beloved novel of manners that examines the themes of love, class, and reputation in early 19th-century England."
                        },
                        new
                        {
                            Id = 14,
                            Name = "The Great Gatsby",
                            PurchasePrice = 10.99m,
                            Text = "F. Scott Fitzgerald's novel of the Jazz Age, a critique of the American Dream through the life of Jay Gatsby."
                        },
                        new
                        {
                            Id = 15,
                            Name = "The Catcher in the Rye",
                            PurchasePrice = 9.49m,
                            Text = "J.D. Salinger's iconic novel following Holden Caulfield, a teenager navigating complex emotions and identity in post-war America."
                        },
                        new
                        {
                            Id = 16,
                            Name = "Moby Dick",
                            PurchasePrice = 11.99m,
                            Text = "Herman Melville's epic tale of obsession and revenge, centered on Captain Ahab's relentless pursuit of the white whale."
                        },
                        new
                        {
                            Id = 17,
                            Name = "War and Peace",
                            PurchasePrice = 12.99m,
                            Text = "Leo Tolstoy's historical masterpiece set during the Napoleonic Wars, examining the interconnected lives of several aristocratic families."
                        },
                        new
                        {
                            Id = 18,
                            Name = "The Odyssey",
                            PurchasePrice = 8.49m,
                            Text = "Homer's ancient epic that follows the hero Odysseus as he faces trials and adventures on his journey home from the Trojan War."
                        },
                        new
                        {
                            Id = 19,
                            Name = "Jane Eyre",
                            PurchasePrice = 7.99m,
                            Text = "Charlotte Brontë’s gothic romance following the life of a resilient orphan girl as she grows up and finds love and self-respect."
                        },
                        new
                        {
                            Id = 20,
                            Name = "The Lord of the Rings",
                            PurchasePrice = 15.99m,
                            Text = "J.R.R. Tolkien's fantasy epic about a group of heroes on a quest to destroy a powerful ring that could bring destruction to Middle-earth."
                        },
                        new
                        {
                            Id = 21,
                            Name = "Ecommerce Evolved: The Essential Playbook To Build, Grow & Scale A Successful Ecommerce Business",
                            PurchasePrice = 19.99m,
                            Text = "Tanner Larsson provides a comprehensive guide on strategies to build and scale a successful eCommerce business."
                        },
                        new
                        {
                            Id = 22,
                            Name = "The Everything Store: Jeff Bezos and the Age of Amazon",
                            PurchasePrice = 14.99m,
                            Text = "Brad Stone explores the story behind Amazon and how Jeff Bezos built it into one of the largest eCommerce platforms in the world."
                        },
                        new
                        {
                            Id = 23,
                            Name = "One Click: Jeff Bezos and the Rise of Amazon.com",
                            PurchasePrice = 11.99m,
                            Text = "Richard L. Brandt details the meteoric rise of Amazon and the innovative strategies employed by Jeff Bezos."
                        },
                        new
                        {
                            Id = 24,
                            Name = "Building a StoryBrand: Clarify Your Message So Customers Will Listen",
                            PurchasePrice = 13.99m,
                            Text = "Donald Miller offers insights on crafting compelling brand stories that connect with customers and drive engagement."
                        },
                        new
                        {
                            Id = 25,
                            Name = "DotCom Secrets: The Underground Playbook for Growing Your Company Online",
                            PurchasePrice = 17.99m,
                            Text = "Russell Brunson shares secrets to successful online sales funnels and increasing conversions in eCommerce."
                        },
                        new
                        {
                            Id = 26,
                            Name = "Contagious: How to Build Word of Mouth in the Digital Age",
                            PurchasePrice = 10.99m,
                            Text = "Jonah Berger explains how to create content that people want to share, an essential aspect for viral marketing in eCommerce."
                        },
                        new
                        {
                            Id = 27,
                            Name = "Click Millionaires: Work Less, Live More with an Internet Business You Love",
                            PurchasePrice = 12.99m,
                            Text = "Scott Fox provides strategies for starting a profitable online business with minimal time investment."
                        },
                        new
                        {
                            Id = 28,
                            Name = "Invisible Selling Machine",
                            PurchasePrice = 9.99m,
                            Text = "Ryan Deiss introduces automated sales strategies to enhance engagement and increase conversions in online businesses."
                        },
                        new
                        {
                            Id = 29,
                            Name = "The Ultimate Guide to Google AdWords",
                            PurchasePrice = 21.99m,
                            Text = "Perry Marshall and Mike Rhodes offer a detailed guide on leveraging Google AdWords for effective digital marketing and eCommerce growth."
                        },
                        new
                        {
                            Id = 30,
                            Name = "E-Commerce 101: Learn How to Start a Profitable Online Business Selling Products Online",
                            PurchasePrice = 16.99m,
                            Text = "Chloe Thomas provides a beginner-friendly guide to launching and running a profitable eCommerce business."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Subscription", b =>
                {
                    b.HasOne("Book", "Book")
                        .WithMany("Subscriptions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUser", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationUser", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
