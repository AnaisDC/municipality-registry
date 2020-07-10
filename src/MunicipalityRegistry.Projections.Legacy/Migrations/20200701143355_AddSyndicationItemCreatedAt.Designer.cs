﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunicipalityRegistry.Projections.Legacy;

namespace MunicipalityRegistry.Projections.Legacy.Migrations
{
    [DbContext(typeof(LegacyContext))]
    [Migration("20200701143355_AddSyndicationItemCreatedAt")]
    partial class AddSyndicationItemCreatedAt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner.ProjectionStates.ProjectionStateItem", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesiredState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("DesiredStateChangedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("Position")
                        .HasColumnType("bigint");

                    b.HasKey("Name")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("ProjectionStates","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityDetail.MunicipalityDetail", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGerman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NisCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("MunicipalityDetails","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityList.MunicipalityListItem", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DefaultName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGerman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NisCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("DefaultName");

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("MunicipalityList","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityName.MunicipalityName", b =>
                {
                    b.Property<Guid>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFlemishRegion")
                        .HasColumnType("bit");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameDutchSearch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglishSearch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrenchSearch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameGerman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGermanSearch")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NisCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("MunicipalityId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("IsFlemishRegion");

                    b.HasIndex("NameDutchSearch");

                    b.HasIndex("NameEnglishSearch");

                    b.HasIndex("NameFrenchSearch");

                    b.HasIndex("NameGermanSearch");

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("VersionTimestampAsDateTimeOffset");

                    b.ToTable("MunicipalityName","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalitySyndication.MunicipalitySyndicationItem", b =>
                {
                    b.Property<long>("Position")
                        .HasColumnType("bigint");

                    b.Property<int?>("Application")
                        .HasColumnType("int");

                    b.Property<string>("ChangeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventDataAsXml")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastChangedOnAsDateTimeOffset")
                        .HasColumnName("LastChangedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("Modification")
                        .HasColumnType("int");

                    b.Property<Guid?>("MunicipalityId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGerman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NisCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Organisation")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RecordCreatedAtAsDateTimeOffset")
                        .HasColumnName("RecordCreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("SyndicationItemCreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Position")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("MunicipalityId");

                    b.HasIndex("Position")
                        .HasName("CI_MunicipalitySyndication_Position")
                        .HasAnnotation("SqlServer:ColumnStoreIndex", "");

                    b.ToTable("MunicipalitySyndication","MunicipalityRegistryLegacy");
                });

            modelBuilder.Entity("MunicipalityRegistry.Projections.Legacy.MunicipalityVersion.MunicipalityVersion", b =>
                {
                    b.Property<Guid?>("MunicipalityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Position")
                        .HasColumnType("bigint");

                    b.Property<int?>("Application")
                        .HasColumnType("int");

                    b.Property<string>("FacilitiesLanguagesAsString")
                        .HasColumnName("FacilitiesLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Modification")
                        .HasColumnType("int");

                    b.Property<string>("NameDutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFrench")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameGerman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NisCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OfficialLanguagesAsString")
                        .HasColumnName("OfficialLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Organisation")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("VersionTimestampAsDateTimeOffset")
                        .HasColumnName("VersionTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("MunicipalityId", "Position")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("MunicipalityId");

                    b.HasIndex("NisCode")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("Position");

                    b.ToTable("MunicipalityVersions","MunicipalityRegistryLegacy");
                });
#pragma warning restore 612, 618
        }
    }
}