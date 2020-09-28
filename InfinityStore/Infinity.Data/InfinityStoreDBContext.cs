using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Infinity.Data
{
    public partial class InfinityStoreDBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private IDbConnection DbConnection { get; }
        public InfinityStoreDBContext(DbContextOptions<InfinityStoreDBContext> options, IConfiguration configuration)
            : base(options)
        {
            this._configuration = configuration;
            DbConnection = new SqlConnection(this._configuration.GetConnectionString("MainConnection"));
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AttributeTranslations> AttributeTranslations { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoryAttributes> CategoryAttributes { get; set; }
        public virtual DbSet<CategoryTranslations> CategoryTranslations { get; set; }
        public virtual DbSet<GlobalSetting> GlobalSettings { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<MerchantStoreProducts> MerchantStoreProducts { get; set; }
        public virtual DbSet<MerchantStores> MerchantStores { get; set; }
        public virtual DbSet<OptionImages> OptionImages { get; set; }
        public virtual DbSet<OptionTranslations> OptionTranslations { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PaymentProviderTranslations> PaymentProviderTranslations { get; set; }
        public virtual DbSet<PaymentProviders> PaymentProviders { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductInstances> ProductInstances { get; set; }
        public virtual DbSet<ProductTranslations> ProductTranslations { get; set; }
        public virtual DbSet<ProductVariations> ProductVariations { get; set; }
        public virtual DbSet<ProductWarehouses> ProductWarehouses { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<ShippingMethodTranslations> ShippingMethodTranslations { get; set; }
        public virtual DbSet<ShippingMethods> ShippingMethods { get; set; }
        public virtual DbSet<ShippingProviderTranslations> ShippingProviderTranslations { get; set; }
        public virtual DbSet<ShippingProviderWarehouses> ShippingProviderWarehouses { get; set; }
        public virtual DbSet<ShippingProviders> ShippingProviders { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Warehouses> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConnection.ToString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(50);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AttributeTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.AttributeTranslations)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeTranslations_Attributes");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AttributeTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeTranslations_Languages");
            });

            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Categories_Categories");
            });

            modelBuilder.Entity<CategoryAttributes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.CategoryAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryOptionValue_OptionValues");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryAttributes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryOptionValue_Categories");
            });

            modelBuilder.Entity<CategoryTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryTranslations)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryTranslations_Categories");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.CategoryTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryTranslations_Languages");
            });

            modelBuilder.Entity<GlobalSetting>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(128);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).HasMaxLength(256);

                entity.Property(e => e.EnglishName).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NativeName).HasMaxLength(256);

                entity.Property(e => e.ThreeLetterIso)
                    .HasColumnName("ThreeLetterISO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TwoLetterIso)
                    .IsRequired()
                    .HasColumnName("TwoLetterISO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerchantStoreProducts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.MerchantStoreId).HasColumnName("MerchantStoreID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.MerchantStore)
                    .WithMany(p => p.MerchantStoreProducts)
                    .HasForeignKey(d => d.MerchantStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerchantStoreProducts_MerchantStores");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MerchantStoreProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MerchantStoreProducts_Products");
            });

            modelBuilder.Entity<MerchantStores>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hotline)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.OwnerId).HasMaxLength(450);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.MerchantStores)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_MerchantStores_MerchantStores");
            });

            modelBuilder.Entity<OptionImages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasColumnName("ImgURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.OptionTranslationId).HasColumnName("OptionTranslationID");

                entity.HasOne(d => d.OptionTranslation)
                    .WithMany(p => p.OptionImages)
                    .HasForeignKey(d => d.OptionTranslationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptionImages_OptionTranslations");
            });

            modelBuilder.Entity<OptionTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.OptionTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptionTranslations_Languages");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.OptionTranslations)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptionTranslations_Options");
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Options_Attributes");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductInstanceId).HasColumnName("ProductInstanceID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Orders");

                entity.HasOne(d => d.ProductInstance)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_ProductInstances");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.CustomerCommune).HasMaxLength(256);

                entity.Property(e => e.CustomerDistrict)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(450);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerProvince)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.DeliveryTs)
                    .HasColumnName("DeliveryTS")
                    .HasMaxLength(512);

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.Note).HasMaxLength(512);

                entity.Property(e => e.PaymentProviderId).HasColumnName("PaymentProviderID");

                entity.Property(e => e.PickupAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PickupCommune).HasMaxLength(256);

                entity.Property(e => e.PickupDistrict)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PickupPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PickupProvince)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PickupTs)
                    .HasColumnName("PickupTS")
                    .HasMaxLength(512);

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_AspNetUsers");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .HasConstraintName("FK_Orders_PaymentProviders");

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.InverseReference)
                    .HasForeignKey(d => d.ReferenceId)
                    .HasConstraintName("FK_Orders_Orders");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_ShippingMethods");
            });

            modelBuilder.Entity<PaymentProviderTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PaymentProviderId).HasColumnName("PaymentProviderID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PaymentProviderTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentProviderTranslations_Languages");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.PaymentProviderTranslations)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentProviderTranslations_PaymentProviders");
            });

            modelBuilder.Entity<PaymentProviders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientKey)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.SecretKey)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_Categories");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_Products");
            });

            modelBuilder.Entity<ProductInstances>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInstances)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductInstances_Products");
            });

            modelBuilder.Entity<ProductTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Keyword).HasMaxLength(256);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.MetaDescription).HasMaxLength(256);

                entity.Property(e => e.MetaKeyword).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeoAlias)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Tag).HasColumnType("ntext");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ProductTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTranslations_Languages");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTranslations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDetails_Products");
            });

            modelBuilder.Entity<ProductVariations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductInstanceId).HasColumnName("ProductInstanceID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOptionValues_OptionValues");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariations_Options");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOptionValues_Products");

                entity.HasOne(d => d.ProductInstance)
                    .WithMany(p => p.ProductVariations)
                    .HasForeignKey(d => d.ProductInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariations_ProductInstances");
            });

            modelBuilder.Entity<ProductWarehouses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductInstanceId).HasColumnName("ProductInstanceID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.ProductInstance)
                    .WithMany(p => p.ProductWarehouses)
                    .HasForeignKey(d => d.ProductInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductWarehouses_ProductInstances");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductWarehouses_Warehouses");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Permissions).HasColumnType("ntext");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("RoleID")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissions_AspNetRoles");
            });

            modelBuilder.Entity<ShippingMethodTranslations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.HasOne(d => d.Language)
                    .WithMany()
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingMethodTranslations_Languages");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany()
                    .HasForeignKey(d => d.ShippingMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingMethodTranslations_ShippingMethods");
            });

            modelBuilder.Entity<ShippingMethods>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShippingProviderId).HasColumnName("ShippingProviderID");

                entity.HasOne(d => d.ShippingProvider)
                    .WithMany(p => p.ShippingMethods)
                    .HasForeignKey(d => d.ShippingProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingMethods_ShippingProviders");
            });

            modelBuilder.Entity<ShippingProviderTranslations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("ImgURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ShippingProviderId).HasColumnName("ShippingProviderID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ShippingProviderTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingProviderTranslations_Languages");

                entity.HasOne(d => d.ShippingProvider)
                    .WithMany(p => p.ShippingProviderTranslations)
                    .HasForeignKey(d => d.ShippingProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingProviderTranslations_ShippingProviders");
            });

            modelBuilder.Entity<ShippingProviderWarehouses>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseId, e.ShippingProviderId })
                    .HasName("PK_ShippingProviderWarehouses_1");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.Property(e => e.ShippingProviderId).HasColumnName("ShippingProviderID");

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.ExternalAddress)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ExternalCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.HasOne(d => d.ShippingProvider)
                    .WithMany(p => p.ShippingProviderWarehouses)
                    .HasForeignKey(d => d.ShippingProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingProviderWarehouses_ShippingProviders");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ShippingProviderWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingProviderWarehouses_Warehouses");
            });

            modelBuilder.Entity<ShippingProviders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientKey)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.SecretKey)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExternalTransId)
                    .IsRequired()
                    .HasColumnName("ExternalTransID")
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentProviderId).HasColumnName("PaymentProviderID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_Orders");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_PaymentProviders");
            });

            modelBuilder.Entity<Warehouses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Commune).HasMaxLength(256);

                entity.Property(e => e.CreatedTs).HasColumnName("CreatedTS");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTs).HasColumnName("LastModifiedTS");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.MerchantId)
                    .HasConstraintName("FK_Warehouses_MerchantStores");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
