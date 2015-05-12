namespace ultimo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostoReparacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReparacionEgresoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetalleReparacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.String(),
                        ReparacionEgresoId = c.Int(nullable: false),
                        CostoReparacionId = c.Int(nullable: false),
                        Subtotal = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CostoReparacions", t => t.CostoReparacionId, cascadeDelete: true)
                .ForeignKey("dbo.ReparacionEgresoes", t => t.ReparacionEgresoId, cascadeDelete: true)
                .Index(t => t.ReparacionEgresoId)
                .Index(t => t.CostoReparacionId);
            
            CreateTable(
                "dbo.ReparacionEgresoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaEgreso = c.DateTime(nullable: false),
                        Observacion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReparacionIngresoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoId = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        Observacion = c.String(),
                        ReparacionEgresoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReparacionEgresoes", t => t.ReparacionEgresoId, cascadeDelete: true)
                .Index(t => t.ReparacionEgresoId);
            
            CreateTable(
                "dbo.Defectos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartesId = c.Int(nullable: false),
                        Descripcion = c.String(),
                        FechaDeteccion = c.DateTime(nullable: false),
                        ReparacionIngresoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Partes", t => t.PartesId, cascadeDelete: true)
                .ForeignKey("dbo.ReparacionIngresoes", t => t.ReparacionIngresoId, cascadeDelete: true)
                .Index(t => t.PartesId)
                .Index(t => t.ReparacionIngresoId);
            
            CreateTable(
                "dbo.Partes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoId = c.Int(),
                        FechaCompra = c.DateTime(nullable: false),
                        FechaCambioEstimado = c.DateTime(nullable: false),
                        NumSerie = c.String(),
                        StockPartesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockPartes", t => t.StockPartesId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculoes", t => t.VehiculoId)
                .Index(t => t.VehiculoId)
                .Index(t => t.StockPartesId);
            
            CreateTable(
                "dbo.StockPartes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Cantidad = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResponsableId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        Patente = c.String(),
                        NumChasis = c.String(),
                        NumMotor = c.String(),
                        Color = c.String(),
                        FechaCompra = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modeloes", t => t.ModeloId, cascadeDelete: true)
                .ForeignKey("dbo.Responsables", t => t.ResponsableId, cascadeDelete: true)
                .Index(t => t.ResponsableId)
                .Index(t => t.ModeloId);
            
            CreateTable(
                "dbo.DetalleVehiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoId = c.Int(nullable: false),
                        FechaEntrada = c.DateTime(nullable: false),
                        FechaSalida = c.DateTime(nullable: false),
                        HorasTrabajadas = c.Int(nullable: false),
                        KilometrosRecorridos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehiculoes", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.VehiculoId);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Categoriía = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Responsables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        DNI = c.Long(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaAsignacion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.ReparacionIngresoes", "ReparacionEgresoId", "dbo.ReparacionEgresoes");
            DropForeignKey("dbo.Defectos", "ReparacionIngresoId", "dbo.ReparacionIngresoes");
            DropForeignKey("dbo.Vehiculoes", "ResponsableId", "dbo.Responsables");
            DropForeignKey("dbo.Partes", "VehiculoId", "dbo.Vehiculoes");
            DropForeignKey("dbo.Vehiculoes", "ModeloId", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.DetalleVehiculoes", "VehiculoId", "dbo.Vehiculoes");
            DropForeignKey("dbo.Partes", "StockPartesId", "dbo.StockPartes");
            DropForeignKey("dbo.Defectos", "PartesId", "dbo.Partes");
            DropForeignKey("dbo.DetalleReparacions", "ReparacionEgresoId", "dbo.ReparacionEgresoes");
            DropForeignKey("dbo.DetalleReparacions", "CostoReparacionId", "dbo.CostoReparacions");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Modeloes", new[] { "MarcaId" });
            DropIndex("dbo.DetalleVehiculoes", new[] { "VehiculoId" });
            DropIndex("dbo.Vehiculoes", new[] { "ModeloId" });
            DropIndex("dbo.Vehiculoes", new[] { "ResponsableId" });
            DropIndex("dbo.Partes", new[] { "StockPartesId" });
            DropIndex("dbo.Partes", new[] { "VehiculoId" });
            DropIndex("dbo.Defectos", new[] { "ReparacionIngresoId" });
            DropIndex("dbo.Defectos", new[] { "PartesId" });
            DropIndex("dbo.ReparacionIngresoes", new[] { "ReparacionEgresoId" });
            DropIndex("dbo.DetalleReparacions", new[] { "CostoReparacionId" });
            DropIndex("dbo.DetalleReparacions", new[] { "ReparacionEgresoId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Responsables");
            DropTable("dbo.Marcas");
            DropTable("dbo.Modeloes");
            DropTable("dbo.DetalleVehiculoes");
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.StockPartes");
            DropTable("dbo.Partes");
            DropTable("dbo.Defectos");
            DropTable("dbo.ReparacionIngresoes");
            DropTable("dbo.ReparacionEgresoes");
            DropTable("dbo.DetalleReparacions");
            DropTable("dbo.CostoReparacions");
        }
    }
}
