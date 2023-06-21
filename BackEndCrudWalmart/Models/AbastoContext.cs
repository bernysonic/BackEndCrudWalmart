using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEndCrudWalmart.Models;

public partial class AbastoContext : DbContext
{
    public AbastoContext()
    {
    }

    public AbastoContext(DbContextOptions<AbastoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AtAccessoryApproval> AtAccessoryApprovals { get; set; }

    public virtual DbSet<AtBoardSelection> AtBoardSelections { get; set; }

    public virtual DbSet<AtBoardSelectionD> AtBoardSelectionDs { get; set; }

    public virtual DbSet<AtCatAccesory> AtCatAccesories { get; set; }

    public virtual DbSet<AtCatAccesoryDesc> AtCatAccesoryDescs { get; set; }

    public virtual DbSet<AtCatBrand> AtCatBrands { get; set; }

    public virtual DbSet<AtCatBrandDesc> AtCatBrandDescs { get; set; }

    public virtual DbSet<AtCatColor> AtCatColors { get; set; }

    public virtual DbSet<AtCatColorDesc> AtCatColorDescs { get; set; }

    public virtual DbSet<AtCatDepartmentUser> AtCatDepartmentUsers { get; set; }

    public virtual DbSet<AtCatDrop> AtCatDrops { get; set; }

    public virtual DbSet<AtCatDropDesc> AtCatDropDescs { get; set; }

    public virtual DbSet<AtCatFabricGroup> AtCatFabricGroups { get; set; }

    public virtual DbSet<AtCatFabricGroupDesc> AtCatFabricGroupDescs { get; set; }

    public virtual DbSet<AtCatFabricType> AtCatFabricTypes { get; set; }

    public virtual DbSet<AtCatFabricTypeDesc> AtCatFabricTypeDescs { get; set; }

    public virtual DbSet<AtCatFabricTypeYarnNumber> AtCatFabricTypeYarnNumbers { get; set; }

    public virtual DbSet<AtCatMeasurementBlock> AtCatMeasurementBlocks { get; set; }

    public virtual DbSet<AtCatMeasurementBlockDesc> AtCatMeasurementBlockDescs { get; set; }

    public virtual DbSet<AtCatMeasurementBlockPlace> AtCatMeasurementBlockPlaces { get; set; }

    public virtual DbSet<AtCatMeasurementBlockPlaceDesc> AtCatMeasurementBlockPlaceDescs { get; set; }

    public virtual DbSet<AtCatMeasurementBlockPlaceDet> AtCatMeasurementBlockPlaceDets { get; set; }

    public virtual DbSet<AtCatOrderStatus> AtCatOrderStatuses { get; set; }

    public virtual DbSet<AtCatOrderStatusDesc> AtCatOrderStatusDescs { get; set; }

    public virtual DbSet<AtCatPrintandEmbroidery> AtCatPrintandEmbroideries { get; set; }

    public virtual DbSet<AtCatPrintandEmbroideryDesc> AtCatPrintandEmbroideryDescs { get; set; }

    public virtual DbSet<AtCatProduct> AtCatProducts { get; set; }

    public virtual DbSet<AtCatProductDesc> AtCatProductDescs { get; set; }

    public virtual DbSet<AtCatProductDet> AtCatProductDets { get; set; }

    public virtual DbSet<AtCatProductSize> AtCatProductSizes { get; set; }

    public virtual DbSet<AtCatRange> AtCatRanges { get; set; }

    public virtual DbSet<AtCatSeason> AtCatSeasons { get; set; }

    public virtual DbSet<AtCatSeasonDesc> AtCatSeasonDescs { get; set; }

    public virtual DbSet<AtCatSize> AtCatSizes { get; set; }

    public virtual DbSet<AtCatSizeDesc> AtCatSizeDescs { get; set; }

    public virtual DbSet<AtCatSizeGroup> AtCatSizeGroups { get; set; }

    public virtual DbSet<AtCatSizeGroupDesc> AtCatSizeGroupDescs { get; set; }

    public virtual DbSet<AtCatSizeGroupDet> AtCatSizeGroupDets { get; set; }

    public virtual DbSet<AtCatTestErrorCode> AtCatTestErrorCodes { get; set; }

    public virtual DbSet<AtCatTestErrorCodesDesc> AtCatTestErrorCodesDescs { get; set; }

    public virtual DbSet<AtCatYarnType> AtCatYarnTypes { get; set; }

    public virtual DbSet<AtCatYarnTypeDesc> AtCatYarnTypeDescs { get; set; }

    public virtual DbSet<AtCriticalPathDataDesc> AtCriticalPathDataDescs { get; set; }

    public virtual DbSet<AtCriticalPathDataTemplate> AtCriticalPathDataTemplates { get; set; }

    public virtual DbSet<AtCriticalPathDataTemplateDet> AtCriticalPathDataTemplateDets { get; set; }

    public virtual DbSet<AtCriticalPathDatum> AtCriticalPathData { get; set; }

    public virtual DbSet<AtDepartment> AtDepartments { get; set; }

    public virtual DbSet<AtDepartmentsDesc> AtDepartmentsDescs { get; set; }

    public virtual DbSet<AtDepartmentsDet> AtDepartmentsDets { get; set; }

    public virtual DbSet<AtFabricApproval> AtFabricApprovals { get; set; }

    public virtual DbSet<AtFichaTecnica> AtFichaTecnicas { get; set; }

    public virtual DbSet<AtFichaTecnicaAccesorio> AtFichaTecnicaAccesorios { get; set; }

    public virtual DbSet<AtFichaTecnicaMeasurement> AtFichaTecnicaMeasurements { get; set; }

    public virtual DbSet<AtFichaTecnicaPrint> AtFichaTecnicaPrints { get; set; }

    public virtual DbSet<AtOrderProd> AtOrderProds { get; set; }

    public virtual DbSet<AtOrderProdCpd> AtOrderProdCpds { get; set; }

    public virtual DbSet<AtOrderProdCpdforLot> AtOrderProdCpdforLots { get; set; }

    public virtual DbSet<AtOrderProdFabric> AtOrderProdFabrics { get; set; }

    public virtual DbSet<AtOrderProdInfo> AtOrderProdInfos { get; set; }

    public virtual DbSet<AtOrderProdInfoDet> AtOrderProdInfoDets { get; set; }

    public virtual DbSet<AtOrderProdInfoDetSize> AtOrderProdInfoDetSizes { get; set; }

    public virtual DbSet<AtOrderProdModel> AtOrderProdModels { get; set; }

    public virtual DbSet<AtOrderProdProcess> AtOrderProdProcesses { get; set; }

    public virtual DbSet<AtOrderProdProcessTest> AtOrderProdProcessTests { get; set; }

    public virtual DbSet<AtOrderProdProcessTestResult> AtOrderProdProcessTestResults { get; set; }

    public virtual DbSet<AtOrderProdSize> AtOrderProdSizes { get; set; }

    public virtual DbSet<AtPrintApproval> AtPrintApprovals { get; set; }

    public virtual DbSet<AtStandardApprovalforLot> AtStandardApprovalforLots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


    }
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); DataBase=Abasto; Trusted_Connection=True; TrustServerCertificate=True;");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AtAccessoryApproval>(entity =>
        {
            entity.HasKey(e => e.UniqueNumber).HasName("XPKAT_AccessoryApproval");

            entity.ToTable("AT_AccessoryApproval");

            entity.Property(e => e.UniqueNumber).ValueGeneratedNever();
            entity.Property(e => e.BuyerApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.Note)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.Qfabric).HasColumnName("QFabric");
            entity.Property(e => e.ResultDate).HasColumnType("datetime");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.StyleNumberApp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StyleNumberAPP");
        });

        modelBuilder.Entity<AtBoardSelection>(entity =>
        {
            entity.HasKey(e => e.IdBoard);

            entity.ToTable("AT_BoardSelection");

            entity.Property(e => e.IdBoard).HasColumnName("Id_Board");
            entity.Property(e => e.DateSelec)
                .HasColumnType("date")
                .HasColumnName("Date_Selec");
            entity.Property(e => e.Season)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtBoardSelectionD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AT_BoardSelectionD");

            entity.Property(e => e.IdBoard).HasColumnName("Id_Board");
            entity.Property(e => e.NoteAbasto)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("Note_Abasto");
            entity.Property(e => e.NoteShopping)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("Note_Shopping");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("status");
        });

        modelBuilder.Entity<AtCatAccesory>(entity =>
        {
            entity.HasKey(e => e.AccessoryNumber).HasName("XPKAT_Cat_Accesory");

            entity.ToTable("AT_Cat_Accesory");

            entity.Property(e => e.AccessoryNumber).ValueGeneratedNever();
            entity.Property(e => e.AccessoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatAccesoryDesc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AT_Cat_AccesoryDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.AccessoryNumberNavigation).WithMany()
                .HasForeignKey(d => d.AccessoryNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_AccesoryDesc_AT_Cat_Accesory");
        });

        modelBuilder.Entity<AtCatBrand>(entity =>
        {
            entity.HasKey(e => e.BrandNumber).HasName("PK__AT_Cat_B__7F6F1AE4819CD7AF");

            entity.ToTable("AT_Cat_Brand");

            entity.Property(e => e.BrandNumber).ValueGeneratedNever();
            entity.Property(e => e.BrandCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BuyerCdsnumber).HasColumnName("BuyerCDSNumber");
        });

        modelBuilder.Entity<AtCatBrandDesc>(entity =>
        {
            entity.HasKey(e => new { e.BrandNumber, e.LanguageCode }).HasName("PK__AT_Cat_B__37D7D247CAE35C94");

            entity.ToTable("AT_Cat_BrandDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.BrandNumberNavigation).WithMany(p => p.AtCatBrandDescs)
                .HasForeignKey(d => d.BrandNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_BrandDesc_AT_Cat_Brand");
        });

        modelBuilder.Entity<AtCatColor>(entity =>
        {
            entity.HasKey(e => e.Color).HasName("XPKAT_Cat_Color");

            entity.ToTable("AT_Cat_Color");

            entity.Property(e => e.Color).ValueGeneratedNever();
            entity.Property(e => e.CodePantone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ColorCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NameFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RgbcolorHexcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RGBColorHexcode");
        });

        modelBuilder.Entity<AtCatColorDesc>(entity =>
        {
            entity.HasKey(e => new { e.Color, e.LanguageCode }).HasName("XPKAT_Cat_ColorDesc");

            entity.ToTable("AT_Cat_ColorDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.AtCatColorDescs)
                .HasForeignKey(d => d.Color)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_ColorDesc_AT_Cat_Color");
        });

        modelBuilder.Entity<AtCatDepartmentUser>(entity =>
        {
            entity.HasKey(e => e.Department);

            entity.ToTable("AT_Cat_DepartmentUsers");

            entity.Property(e => e.Department).ValueGeneratedNever();
            entity.Property(e => e.RelationType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ResponsibleCompanyCdsnumber).HasColumnName("ResponsibleCompanyCDSNumber");
            entity.Property(e => e.ResponsiblePersonCdsnumber).HasColumnName("ResponsiblePersonCDSNumber");
        });

        modelBuilder.Entity<AtCatDrop>(entity =>
        {
            entity.HasKey(e => e.DropNumber);

            entity.ToTable("AT_Cat_Drop");

            entity.Property(e => e.DropNumber).ValueGeneratedNever();
            entity.Property(e => e.DropCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatDropDesc>(entity =>
        {
            entity.HasKey(e => new { e.DropNumber, e.LanguageCode }).HasName("XPKAT_Cat_DropDesc");

            entity.ToTable("AT_Cat_DropDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.DropNumberNavigation).WithMany(p => p.AtCatDropDescs)
                .HasForeignKey(d => d.DropNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_DropDesc_AT_Cat_Drop");
        });

        modelBuilder.Entity<AtCatFabricGroup>(entity =>
        {
            entity.HasKey(e => e.FabricGroupNumber).HasName("XPKAT_Cat_FabricGroup");

            entity.ToTable("AT_Cat_FabricGroup");

            entity.Property(e => e.FabricGroupNumber).ValueGeneratedNever();
            entity.Property(e => e.FabricGroupcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FabricGroupcode2)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("FabricGroupcode_2");
        });

        modelBuilder.Entity<AtCatFabricGroupDesc>(entity =>
        {
            entity.HasKey(e => new { e.FabricGroupNumber, e.LanguageCode }).HasName("XPKAT_Cat_FabricGroupDesc");

            entity.ToTable("AT_Cat_FabricGroupDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.FabricGroupNumberNavigation).WithMany(p => p.AtCatFabricGroupDescs)
                .HasForeignKey(d => d.FabricGroupNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_FabricGroupDesc_AT_Cat_FabricGroup");
        });

        modelBuilder.Entity<AtCatFabricType>(entity =>
        {
            entity.HasKey(e => new { e.FabricGroupNumber, e.RowNumber });

            entity.ToTable("AT_Cat_FabricType");

            entity.Property(e => e.Composition)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("composition");
            entity.Property(e => e.FabricType1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fabricweight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.YarnTypePercentage1).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.YarnTypePercentage2).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.YarnTypePercentage3).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.YarnTypePercentage4).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.YarnTypePercentage5).HasColumnType("numeric(8, 4)");
        });

        modelBuilder.Entity<AtCatFabricTypeDesc>(entity =>
        {
            entity.HasKey(e => new { e.FabricGroupNumber, e.RowNumber, e.LanguageCode }).HasName("XPKAT_Cat_FabricTypeDesc");

            entity.ToTable("AT_Cat_FabricTypeDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.AtCatFabricType).WithMany(p => p.AtCatFabricTypeDescs)
                .HasForeignKey(d => new { d.FabricGroupNumber, d.RowNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_FabricTypeDesc_AT_Cat_FabricType");
        });

        modelBuilder.Entity<AtCatFabricTypeYarnNumber>(entity =>
        {
            entity.HasKey(e => new { e.FabricGroupNumber, e.RowNumber, e.YarnNumber }).HasName("XPKAT_Cat_FabricTypeYarnNumber");

            entity.ToTable("AT_Cat_FabricTypeYarnNumber");

            entity.Property(e => e.YarnTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AtCatFabricType).WithMany(p => p.AtCatFabricTypeYarnNumbers)
                .HasForeignKey(d => new { d.FabricGroupNumber, d.RowNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_FabricTypeYarnNumber_AT_Cat_FabricType");
        });

        modelBuilder.Entity<AtCatMeasurementBlock>(entity =>
        {
            entity.HasKey(e => e.BlockNumber).HasName("XPKAT_Cat_MeasurementBlock");

            entity.ToTable("AT_Cat_MeasurementBlock");

            entity.Property(e => e.BlockNumber).ValueGeneratedNever();
            entity.Property(e => e.BlockCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MeasurementUnitCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatMeasurementBlockDesc>(entity =>
        {
            entity.HasKey(e => new { e.BlockNumber, e.LanguageCode }).HasName("XPKAT_Cat_MeasurementBlockDesc");

            entity.ToTable("AT_Cat_MeasurementBlockDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.BlockNumberNavigation).WithMany(p => p.AtCatMeasurementBlockDescs)
                .HasForeignKey(d => d.BlockNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_MeasurementBlockDesc_AT_Cat_MeasurementBlock");
        });

        modelBuilder.Entity<AtCatMeasurementBlockPlace>(entity =>
        {
            entity.HasKey(e => new { e.BlockNumber, e.RowNumber }).HasName("PK__AT_Cat_M__8E54958E8104B9AB");

            entity.ToTable("AT_Cat_MeasurementBlockPlace");

            entity.Property(e => e.Indicator)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ToleranceValue).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<AtCatMeasurementBlockPlaceDesc>(entity =>
        {
            entity.HasKey(e => new { e.BlockNumber, e.RowNumber, e.LanguageCode }).HasName("XPKAT_Cat_MeasurementBlockPlaceDesc");

            entity.ToTable("AT_Cat_MeasurementBlockPlaceDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.AtCatMeasurementBlockPlace).WithMany(p => p.AtCatMeasurementBlockPlaceDescs)
                .HasForeignKey(d => new { d.BlockNumber, d.RowNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_MeasurementBlockPlaceDesc_AT_Cat_MeasurementBlockPlace");
        });

        modelBuilder.Entity<AtCatMeasurementBlockPlaceDet>(entity =>
        {
            entity.HasKey(e => new { e.BlockNumber, e.RowNumber, e.DropNumber, e.Size }).HasName("PK__AT_Cat_M__C08F5212939C8175");

            entity.ToTable("AT_Cat_MeasurementBlockPlaceDet");

            entity.Property(e => e.GradingValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GradingValue1).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.MeasurementValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MeasurementValue1).HasColumnType("decimal(10, 4)");

            entity.HasOne(d => d.AtCatMeasurementBlockPlace).WithMany(p => p.AtCatMeasurementBlockPlaceDets)
                .HasForeignKey(d => new { d.BlockNumber, d.RowNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_MeasurementBlockPlaceDet_AT_Cat_MeasurementBlockPlace");
        });

        modelBuilder.Entity<AtCatOrderStatus>(entity =>
        {
            entity.HasKey(e => e.StatusNumber).HasName("XPKAT_Cat_OrderStatus");

            entity.ToTable("AT_Cat_OrderStatus");

            entity.Property(e => e.StatusNumber).ValueGeneratedNever();
            entity.Property(e => e.StatusCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatOrderStatusDesc>(entity =>
        {
            entity.HasKey(e => new { e.StatusNumber, e.LanguageCode }).HasName("XPKAT_Cat_OrderStatusDesc");

            entity.ToTable("AT_Cat_OrderStatusDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.StatusNumberNavigation).WithMany(p => p.AtCatOrderStatusDescs)
                .HasForeignKey(d => d.StatusNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_OrderStatusDesc_AT_Cat_OrderStatus");
        });

        modelBuilder.Entity<AtCatPrintandEmbroidery>(entity =>
        {
            entity.HasKey(e => e.PrintNumber).HasName("XPKAT_Cat_PrintandEmbroidery");

            entity.ToTable("AT_Cat_PrintandEmbroidery");

            entity.Property(e => e.PrintNumber).ValueGeneratedNever();
            entity.Property(e => e.PrintCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatPrintandEmbroideryDesc>(entity =>
        {
            entity.HasKey(e => new { e.PrintNumber, e.LanguageCode }).HasName("XPKAT_Cat_PrintandEmbroideryDesc");

            entity.ToTable("AT_Cat_PrintandEmbroideryDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.PrintNumberNavigation).WithMany(p => p.AtCatPrintandEmbroideryDescs)
                .HasForeignKey(d => d.PrintNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_PrintandEmbroideryDesc_AT_Cat_PrintandEmbroidery");
        });

        modelBuilder.Entity<AtCatProduct>(entity =>
        {
            entity.HasKey(e => e.ProductType).HasName("XPKAT_Cat_Product");

            entity.ToTable("AT_Cat_Product");

            entity.Property(e => e.ProductType).ValueGeneratedNever();
            entity.Property(e => e.IdProductTypeGdm).HasColumnName("Id_ProductType_GDM");
        });

        modelBuilder.Entity<AtCatProductDesc>(entity =>
        {
            entity.HasKey(e => new { e.ProductType, e.LanguageCode }).HasName("XPKAT_Cat_ProductDesc");

            entity.ToTable("AT_Cat_ProductDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.ProductTypeNavigation).WithMany(p => p.AtCatProductDescs)
                .HasForeignKey(d => d.ProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_ProductDesc_AT_Cat_Product");
        });

        modelBuilder.Entity<AtCatProductDet>(entity =>
        {
            entity.HasKey(e => new { e.ProductType, e.AttachedProductType }).HasName("XPKAT_Cat_ProductDet");

            entity.ToTable("AT_Cat_ProductDet");

            entity.HasOne(d => d.ProductTypeNavigation).WithMany(p => p.AtCatProductDets)
                .HasForeignKey(d => d.ProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_ProductDet_AT_Cat_Product");
        });

        modelBuilder.Entity<AtCatProductSize>(entity =>
        {
            entity.HasKey(e => new { e.ProductType, e.BlockNumber }).HasName("XPKAT_Cat_ProductSize");

            entity.ToTable("AT_Cat_ProductSize");

            entity.HasOne(d => d.ProductTypeNavigation).WithMany(p => p.AtCatProductSizes)
                .HasForeignKey(d => d.ProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_ProductSize_AT_Cat_Product");
        });

        modelBuilder.Entity<AtCatRange>(entity =>
        {
            entity.HasKey(e => e.Range).HasName("XPKAT_Cat_Range");

            entity.ToTable("AT_Cat_Range");

            entity.Property(e => e.Range).ValueGeneratedNever();
            entity.Property(e => e.RangeCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");
        });

        modelBuilder.Entity<AtCatSeason>(entity =>
        {
            entity.HasKey(e => e.Season).IsClustered(false);

            entity.ToTable("AT_Cat_Season");

            entity.Property(e => e.Awss)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AWSS");
            entity.Property(e => e.SeasonCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatSeasonDesc>(entity =>
        {
            entity.HasKey(e => new { e.Season, e.LanguageCode }).HasName("XPKAT_Cat_SeasonDesc");

            entity.ToTable("AT_Cat_SeasonDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.SeasonNavigation).WithMany(p => p.AtCatSeasonDescs)
                .HasForeignKey(d => d.Season)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_SeasonDesc_AT_Cat_Season");
        });

        modelBuilder.Entity<AtCatSize>(entity =>
        {
            entity.HasKey(e => e.Size).HasName("XPKAT_Cat_Size");

            entity.ToTable("AT_Cat_Size");

            entity.Property(e => e.Size).ValueGeneratedNever();
            entity.Property(e => e.SizeCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatSizeDesc>(entity =>
        {
            entity.HasKey(e => new { e.Size, e.LanguageCode }).HasName("XPKAT_Cat_SizeDesc");

            entity.ToTable("AT_Cat_SizeDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.AtCatSizeDescs)
                .HasForeignKey(d => d.Size)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_SizeDesc_AT_Cat_Size");
        });

        modelBuilder.Entity<AtCatSizeGroup>(entity =>
        {
            entity.HasKey(e => e.SizeGroupNumber).HasName("XPKAT_Cat_SizeGroup");

            entity.ToTable("AT_Cat_SizeGroup");

            entity.Property(e => e.SizeGroupNumber).ValueGeneratedNever();
            entity.Property(e => e.SizeGroupCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtCatSizeGroupDesc>(entity =>
        {
            entity.HasKey(e => new { e.SizeGroupNumber, e.LanguageCode }).HasName("XPKAT_Cat_SizeGroupDesc");

            entity.ToTable("AT_Cat_SizeGroupDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.SizeGroupNumberNavigation).WithMany(p => p.AtCatSizeGroupDescs)
                .HasForeignKey(d => d.SizeGroupNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_SizeGroupDesc_AT_Cat_SizeGroup");
        });

        modelBuilder.Entity<AtCatSizeGroupDet>(entity =>
        {
            entity.HasKey(e => new { e.SizeGroupNumber, e.Size }).HasName("XPKAT_Cat_SizeGroupDet");

            entity.ToTable("AT_Cat_SizeGroupDet");

            entity.HasOne(d => d.SizeGroupNumberNavigation).WithMany(p => p.AtCatSizeGroupDets)
                .HasForeignKey(d => d.SizeGroupNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_SizeGroupDet_AT_Cat_SizeGroup");
        });

        modelBuilder.Entity<AtCatTestErrorCode>(entity =>
        {
            entity.HasKey(e => e.ErrorCode).HasName("XPKAt_Cat_TestErrorCodes");

            entity.ToTable("At_Cat_TestErrorCodes");

            entity.Property(e => e.ErrorCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<AtCatTestErrorCodesDesc>(entity =>
        {
            entity.HasKey(e => new { e.ErrorCode, e.LanguageCode }).HasName("XPKAt_Cat_TestErrorCodesDesc");

            entity.ToTable("At_Cat_TestErrorCodesDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.ErrorCodeNavigation).WithMany(p => p.AtCatTestErrorCodesDescs)
                .HasForeignKey(d => d.ErrorCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_At_Cat_TestErrorCodesDesc_At_Cat_TestErrorCodes");
        });

        modelBuilder.Entity<AtCatYarnType>(entity =>
        {
            entity.HasKey(e => e.YarnTypeNumber).HasName("XPKAT_Cat_YarnType");

            entity.ToTable("AT_Cat_YarnType");

            entity.Property(e => e.YarnTypeNumber).ValueGeneratedNever();
            entity.Property(e => e.Percentage).HasColumnType("numeric(8, 4)");
        });

        modelBuilder.Entity<AtCatYarnTypeDesc>(entity =>
        {
            entity.HasKey(e => new { e.YarnTypeNumber, e.LanguageCode }).HasName("XPKAT_Cat_YarnTypeDesc");

            entity.ToTable("AT_Cat_YarnTypeDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.YarnTypeNumberNavigation).WithMany(p => p.AtCatYarnTypeDescs)
                .HasForeignKey(d => d.YarnTypeNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Cat_YarnTypeDesc_AT_Cat_YarnType");
        });

        modelBuilder.Entity<AtCriticalPathDataDesc>(entity =>
        {
            entity.HasKey(e => new { e.JobNumber, e.LanguageCode }).HasName("XPKAT_CriticalPathDataDesc");

            entity.ToTable("AT_CriticalPathDataDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.JobNumberNavigation).WithMany(p => p.AtCriticalPathDataDescs)
                .HasForeignKey(d => d.JobNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_CriticalPathDataDesc_AT_CriticalPathData");
        });

        modelBuilder.Entity<AtCriticalPathDataTemplate>(entity =>
        {
            entity.HasKey(e => e.TamplateNumber).HasName("XPKAT_CriticalPathDataTemplate");

            entity.ToTable("AT_CriticalPathDataTemplate");

            entity.Property(e => e.TamplateNumber).ValueGeneratedNever();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");
        });

        modelBuilder.Entity<AtCriticalPathDataTemplateDet>(entity =>
        {
            entity.HasKey(e => new { e.TamplateNumber, e.RowNumber }).HasName("XPKAT_CriticalPathDataTemplateDet");

            entity.ToTable("AT_CriticalPathDataTemplateDet");

            entity.Property(e => e.Formula)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.ResponsibleGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.TamplateNumberNavigation).WithMany(p => p.AtCriticalPathDataTemplateDets)
                .HasForeignKey(d => d.TamplateNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_CriticalPathDataTemplateDet_AT_CriticalPathDataTemplate");
        });

        modelBuilder.Entity<AtCriticalPathDatum>(entity =>
        {
            entity.HasKey(e => e.JobNumber).HasName("XPKAT_CriticalPathData");

            entity.ToTable("AT_CriticalPathData");

            entity.Property(e => e.JobNumber).ValueGeneratedNever();
            entity.Property(e => e.Email).HasColumnName("EMail");
            entity.Property(e => e.ProcessTypeCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtDepartment>(entity =>
        {
            entity.HasKey(e => e.Department).HasName("XPKAT_Departments");

            entity.ToTable("AT_Departments");

            entity.Property(e => e.Department).ValueGeneratedNever();
            entity.Property(e => e.HangBox)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDptoSub).HasColumnName("Id_Dpto_Sub");
            entity.Property(e => e.TransportationType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnitCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtDepartmentsDesc>(entity =>
        {
            entity.HasKey(e => new { e.Department, e.LanguageCode }).HasName("XPKAT_DepartmentsDesc");

            entity.ToTable("AT_DepartmentsDesc");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.AtDepartmentsDescs)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_DepartmentsDesc_AT_Departments");
        });

        modelBuilder.Entity<AtDepartmentsDet>(entity =>
        {
            entity.HasKey(e => new { e.Department, e.AttachedDept, e.Level }).HasName("XPKAT_DepartmentsDet");

            entity.ToTable("AT_DepartmentsDet");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.AtDepartmentsDets)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_DepartmentsDet_AT_Departments");
        });

        modelBuilder.Entity<AtFabricApproval>(entity =>
        {
            entity.HasKey(e => e.UniqueNumber).HasName("XPKAT_FabricApproval");

            entity.ToTable("AT_FabricApproval");

            entity.Property(e => e.UniqueNumber).ValueGeneratedNever();
            entity.Property(e => e.BuyerApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.Note)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.ResultDate).HasColumnType("datetime");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.StyleNumberApp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StyleNumberAPP");
        });

        modelBuilder.Entity<AtFichaTecnica>(entity =>
        {
            entity.HasKey(e => e.ModelNumber);

            entity.ToTable("AT_Ficha_Tecnica");

            entity.Property(e => e.BuyerCdsnumber).HasColumnName("BuyerCDSNumber");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DesignDescription)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.DesignNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MeasurementUnitCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PicturePathonthesystem)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.PreviousPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.PriceTarget).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.PriceTotal).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.SignatureAbasto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SignatureDesign)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SignatureShopping)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StyleNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StyleOwnerCdsnumber).HasColumnName("StyleOwnerCDSNumber");
            entity.Property(e => e.VendorCdsno).HasColumnName("VendorCDSNo");
        });

        modelBuilder.Entity<AtFichaTecnicaAccesorio>(entity =>
        {
            entity.HasKey(e => new { e.ModelNumber, e.RowNumber });

            entity.ToTable("AT_Ficha_Tecnica_Accesorios");

            entity.Property(e => e.Qfabric).HasColumnName("QFabric");
            entity.Property(e => e.WhereUsedDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ModelNumberNavigation).WithMany(p => p.AtFichaTecnicaAccesorios)
                .HasForeignKey(d => d.ModelNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Ficha_Tecnica_Accesorios_AT_Ficha_Tecnica");
        });

        modelBuilder.Entity<AtFichaTecnicaMeasurement>(entity =>
        {
            entity.HasKey(e => new { e.ModelNumber, e.RowNumber }).HasName("PK__AT_Ficha__FE88508397BC357C");

            entity.ToTable("AT_Ficha_Tecnica_Measurements");

            entity.Property(e => e.Flag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GradingValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.GradingValue1).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Indicator)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemarksAck)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");
            entity.Property(e => e.ToleranceValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ToleranceValue1).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Value1).HasColumnType("decimal(10, 4)");

            entity.HasOne(d => d.ModelNumberNavigation).WithMany(p => p.AtFichaTecnicaMeasurements)
                .HasForeignKey(d => d.ModelNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Ficha_Tecnica_Measurements_AT_Ficha_Tecnica");
        });

        modelBuilder.Entity<AtFichaTecnicaPrint>(entity =>
        {
            entity.HasKey(e => new { e.ModelNumber, e.RowNumber }).HasName("XPKAT_Ficha_Tecnica_Print");

            entity.ToTable("AT_Ficha_Tecnica_Print");

            entity.Property(e => e.Notes)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WhereUsedDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ModelNumberNavigation).WithMany(p => p.AtFichaTecnicaPrints)
                .HasForeignKey(d => d.ModelNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_Ficha_Tecnica_Print_AT_Ficha_Tecnica");
        });

        modelBuilder.Entity<AtOrderProd>(entity =>
        {
            entity.HasKey(e => e.OrderNumber).HasName("XPKAT_OrderProd");

            entity.ToTable("AT_OrderProd");

            entity.Property(e => e.OrderNumber).ValueGeneratedNever();
            entity.Property(e => e.BuyerCdsnumber).HasColumnName("BuyerCDSNumber");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.Commission).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.CountryOrigin).HasColumnName("Country_Origin");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.ResponsibleMerchandiserCdsnumber).HasColumnName("ResponsibleMerchandiserCDSNumber");
            entity.Property(e => e.SetPackageReferenceNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VendorCdsno).HasColumnName("VendorCDSNo");
        });

        modelBuilder.Entity<AtOrderProdCpd>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.ProcessNumber, e.Cpdnumber }).HasName("PK__AT_Order__A7503A809A81958C");

            entity.ToTable("AT_OrderProdCPD");

            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.Formula)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.JobDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");
            entity.Property(e => e.ResponsibleGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Selection).HasColumnName("selection");

            entity.HasOne(d => d.AtOrderProdProcess).WithMany(p => p.AtOrderProdCpds)
                .HasForeignKey(d => new { d.OrderNumber, d.ProcessNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdCPD_AT_OrderProdProcess");
        });

        modelBuilder.Entity<AtOrderProdCpdforLot>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.ProcessNumber, e.Cpdnumber, e.InformationSequenceNumber }).HasName("PK__AT_Order__F95DB60CACE29C62");

            entity.ToTable("AT_OrderProdCPDforLot");

            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.Notes)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");

            entity.HasOne(d => d.AtOrderProdCpd).WithMany(p => p.AtOrderProdCpdforLots)
                .HasForeignKey(d => new { d.OrderNumber, d.ProcessNumber, d.Cpdnumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdCPDforLot_AT_OrderProdCPD");
        });

        modelBuilder.Entity<AtOrderProdFabric>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.ProcessColorCode, e.RowNumber });

            entity.ToTable("AT_OrderProdFabric");

            entity.Property(e => e.RowNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.TelasXcolor).HasColumnName("TelasXColor");

            entity.HasOne(d => d.OrderNumberNavigation).WithMany(p => p.AtOrderProdFabrics)
                .HasForeignKey(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdFabric_AT_OrderProd");
        });

        modelBuilder.Entity<AtOrderProdInfo>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.InformationSequenceNumber }).HasName("XPKAT_OrderProdInfo");

            entity.ToTable("AT_OrderProdInfo");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAuthorizationDate).HasColumnType("datetime");
            entity.Property(e => e.FactoryId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Factory_ID");
            entity.Property(e => e.HangBox)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdPort).HasColumnName("Id_Port");
            entity.Property(e => e.Identnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDENTNumber");
            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.ManufacturersLoadingDate).HasColumnType("datetime");
            entity.Property(e => e.Margin).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.NoofItems).HasColumnType("numeric(20, 3)");
            entity.Property(e => e.Notes)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.OrigDardate)
                .HasColumnType("datetime")
                .HasColumnName("OrigDARdate");
            entity.Property(e => e.OrigLoadingDate).HasColumnType("datetime");
            entity.Property(e => e.Origquantity).HasColumnType("numeric(20, 3)");
            entity.Property(e => e.PackageInsurancePrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.PackageManufacturerPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.PackagePrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.PurchaseOrderDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Reservationdate).HasColumnType("datetime");
            entity.Property(e => e.RetailPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.ShippingDate).HasColumnType("datetime");
            entity.Property(e => e.ShippingType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StorageareaBookingNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StorageareaCdsnumber).HasColumnName("StorageareaCDSnumber");
            entity.Property(e => e.Storeprice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.TotalQuantity).HasColumnType("numeric(20, 3)");
            entity.Property(e => e.TransportationPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.TransportationType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnitCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.OrderNumberNavigation).WithMany(p => p.AtOrderProdInfos)
                .HasForeignKey(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdInfo_AT_OrderProd");
        });

        modelBuilder.Entity<AtOrderProdInfoDet>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.InformationSequenceNumber, e.DetailSequenceNumber }).HasName("XPKAT_OrderProdInfoDet");

            entity.ToTable("AT_OrderProdInfoDet");

            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.NoofItems).HasColumnType("numeric(20, 3)");

            entity.HasOne(d => d.AtOrderProdInfo).WithMany(p => p.AtOrderProdInfoDets)
                .HasForeignKey(d => new { d.OrderNumber, d.InformationSequenceNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdInfoDet_AT_OrderProdInfo1");
        });

        modelBuilder.Entity<AtOrderProdInfoDetSize>(entity =>
        {
            entity.HasKey(e => e.OrderNumber);

            entity.ToTable("AT_OrderProdInfoDetSize");

            entity.Property(e => e.OrderNumber).ValueGeneratedNever();
            entity.Property(e => e.ManufacturerPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.NoofItems).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Percentage).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.SellingPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.VendorPrice).HasColumnType("decimal(24, 5)");

            entity.HasOne(d => d.AtOrderProdInfoDet).WithMany(p => p.AtOrderProdInfoDetSizes)
                .HasForeignKey(d => new { d.OrderNumber, d.InformationSequenceNumber, d.DetailSequenceNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdInfoDetSize_AT_OrderProdInfoDet");
        });

        modelBuilder.Entity<AtOrderProdModel>(entity =>
        {
            entity.HasKey(e => e.OrderNumber);

            entity.ToTable("AT_OrderProdModel");

            entity.Property(e => e.OrderNumber).ValueGeneratedNever();
            entity.Property(e => e.NoofItems).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.OrderNumberNavigation).WithOne(p => p.AtOrderProdModel)
                .HasForeignKey<AtOrderProdModel>(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdModel_AT_OrderProd");
        });

        modelBuilder.Entity<AtOrderProdProcess>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.ProcessNumber }).HasName("XPKAT_OrderProdProcess");

            entity.ToTable("AT_OrderProdProcess");

            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.ManufacturersApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.ManufacturersLoadingDate).HasColumnType("datetime");
            entity.Property(e => e.ManufacturersResponsiblepersonCdsnumber).HasColumnName("ManufacturersResponsiblepersonCDSNumber");
            entity.Property(e => e.OrderDateatCpd)
                .HasColumnType("datetime")
                .HasColumnName("OrderDateatCPD");
            entity.Property(e => e.OrderDateatCpd2)
                .HasColumnType("datetime")
                .HasColumnName("OrderDateatCPD2");

            entity.HasOne(d => d.OrderNumberNavigation).WithMany(p => p.AtOrderProdProcesses)
                .HasForeignKey(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdProcess_AT_OrderProd");
        });

        modelBuilder.Entity<AtOrderProdProcessTest>(entity =>
        {
            entity.HasKey(e => new { e.ProcessNumber, e.RowNumber, e.OrderNumber }).HasName("XPKAT_OrderProdProcessTest");

            entity.ToTable("AT_OrderProdProcessTest");

            entity.Property(e => e.Selection).HasColumnName("selection");

            entity.HasOne(d => d.AtOrderProdProcess).WithMany(p => p.AtOrderProdProcessTests)
                .HasForeignKey(d => new { d.OrderNumber, d.ProcessNumber })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdProcessTest_AT_OrderProdProcess");
        });

        modelBuilder.Entity<AtOrderProdProcessTestResult>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.ProcessNumber, e.RowNumber, e.Resultsequencenumber }).HasName("XPKAT_OrderProdProcessTestResult");

            entity.ToTable("AT_OrderProdProcessTestResult");

            entity.Property(e => e.RemarksAck)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("RemarksACK");
            entity.Property(e => e.TestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AtOrderProdSize>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.InformationSequenceNumber, e.Size, e.DropNumber }).HasName("PK__AT_Order__0801514DA5EC531C");

            entity.ToTable("AT_OrderProdSize");

            entity.Property(e => e.Assorty).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodTax)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Commission).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.Identnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDENTNumber");
            entity.Property(e => e.InsuranceCost).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ManufacturerPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.NoofItems).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Percentage).HasColumnType("numeric(8, 4)");
            entity.Property(e => e.Pomno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POMNo");
            entity.Property(e => e.SellingPrice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.Sequence)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Storeprice).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.SubSequence)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Transportationcost).HasColumnType("decimal(24, 5)");
            entity.Property(e => e.VendorCloserPack).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.VendorPrice).HasColumnType("decimal(24, 5)");

            entity.HasOne(d => d.OrderNumberNavigation).WithMany(p => p.AtOrderProdSizes)
                .HasForeignKey(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AT_OrderProdSize_AT_OrderProd");
        });

        modelBuilder.Entity<AtPrintApproval>(entity =>
        {
            entity.HasKey(e => e.UniqueNumber).HasName("XPKAT_PrintApproval");

            entity.ToTable("AT_PrintApproval");

            entity.Property(e => e.UniqueNumber).ValueGeneratedNever();
            entity.Property(e => e.BuyerApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.ManufacturerCdscode).HasColumnName("ManufacturerCDSCode");
            entity.Property(e => e.Note)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.ResultDate).HasColumnType("datetime");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AtStandardApprovalforLot>(entity =>
        {
            entity.HasKey(e => e.UniqueNumber).HasName("PK__AT_Stand__61DD9BC0FE639CEC");

            entity.ToTable("AT_StandardApprovalforLot");

            entity.Property(e => e.UniqueNumber).ValueGeneratedNever();
            entity.Property(e => e.Cpdnumber).HasColumnName("CPDNumber");
            entity.Property(e => e.Note)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
