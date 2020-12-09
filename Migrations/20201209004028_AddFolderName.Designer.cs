﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using emojipad.Shared;

namespace emojipad.Migrations
{
    [DbContext(typeof(EmojiContext))]
    [Migration("20201209004028_AddFolderName")]
    partial class AddFolderName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("emojipad.Shared.Emoji", b =>
                {
                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FolderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullFilePath")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsedFrequency")
                        .HasColumnType("INTEGER");

                    b.HasKey("FileName");

                    b.ToTable("Emojis");
                });
#pragma warning restore 612, 618
        }
    }
}
