using Microsoft.EntityFrameworkCore;
using Cartsy.Api.Entities;

namespace Cartsy.Api.DbContexts;

public class CartsyContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<LegalCustomer> LegalCustomers { get; set; } = null!;
    public DbSet<NaturalCustomer> NaturalCustomers { get; set; } = null!;

    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Consumer> Consumers { get; set; } = null!;


    public DbSet<Store> Stores { get; set; } = null!;
    public DbSet<StoreService> StoreServices { get; set; } = null!;
    public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<ItemType> ItemTypes { get; set; } = null!;
    public DbSet<AdditionalServices> AdditionalServices { get; set; } = null!;


    public CartsyContext(DbContextOptions<CartsyContext> options)
    : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var customer = modelBuilder.Entity<Customer>();
        
        customer
            .ToTable("Customers")
            .HasDiscriminator(c => c.TypeDiscriminator)
            .HasValue<LegalCustomer>(1)
            .HasValue<NaturalCustomer>(2);

        customer
            .Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();

        

        customer
            .Property(p => p.Email)
            .HasMaxLength(100)
            .IsRequired();

        customer
            .Property(p => p.CellPhone)
            .HasMaxLength(13)
            .IsFixedLength()
            .IsRequired();

        customer
            .Property(p => p.HomePhone)
            .HasMaxLength(13)
            .IsFixedLength();

        customer
            .Property(c => c.Status);

        customer
            .HasOne(c => c.Address)
            .WithOne(a => a.Customer)
            .HasForeignKey<Customer>(c => c.AddressId);

        customer
            .HasOne(c => c.Store)
            .WithOne(s => s.Customer)
            .HasForeignKey<Store>(c => c.CustomerId);


        var consumer = modelBuilder.Entity<Consumer>();

        consumer
            .Property(c => c.CPF)
            .IsFixedLength()
            .HasMaxLength(11)
            .IsRequired();
        
        consumer
            .Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();

        consumer
            .Property(p => p.Email)
            .HasMaxLength(100)
            .IsRequired();

        consumer
            .Property(p => p.CellPhone)
            .HasMaxLength(13)
            .IsFixedLength()
            .IsRequired();

        consumer
            .Property(p => p.HomePhone)
            .HasMaxLength(13)
            .IsFixedLength();
        
        consumer
            .Property(c => c.Status);

        consumer
            .HasOne(p => p.Address)
            .WithOne(a => a.Consumer)
            .HasForeignKey<Consumer>(c => c.AddressId);

        var naturalCustomer = modelBuilder.Entity<NaturalCustomer>();

        naturalCustomer.Property(c => c.CPF)
            .IsFixedLength()
            .HasMaxLength(11)
            .IsRequired();
        naturalCustomer
            .Property(p => p.Type)
            .IsRequired();

        var legalCustomer = modelBuilder.Entity<LegalCustomer>();

        legalCustomer.Property(c => c.CNPJ)
            .IsFixedLength()
            .HasMaxLength(14)
            .IsRequired();
        
        legalCustomer
            .Property(p => p.Type)
            .IsRequired();


        
        var address = modelBuilder.Entity<Address>();

       

        address
            .Property(s => s.State)
            .HasMaxLength(50)
            .IsRequired();
        
        address
            .Property(s => s.UF)
            .HasMaxLength(2)
            .IsFixedLength()
            .IsRequired();
        

        address
            .Property(c => c.City)
            .HasMaxLength(100)
            .IsRequired();

        address
            .Property(a => a.Number)
            .IsRequired();

        address
            .Property(a => a.Street)
            .HasMaxLength(50)
            .IsRequired();

        address
            .Property(a => a.CEP)
            .HasMaxLength(8)
            .IsFixedLength()
            .IsRequired();

        var store = modelBuilder.Entity<Store>();

        store
            .HasOne(s => s.Address)
            .WithOne(a => a.Store)
            .HasForeignKey<Store>(s => s.AddressId);

        store
            .HasMany(s => s.Services)
            .WithMany(s => s.Stores)
            .UsingEntity<StoreService>(ss => ss.ToTable("StoresServices")
                .Property(ss => ss.CreatedAt).HasDefaultValueSql("NOW()")
            );

        store
            .Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();

        store
            .HasMany(s => s.Items)
            .WithOne(i => i.Store)
            .HasForeignKey(s => s.StoreId);

        var order = modelBuilder.Entity<Order>();

        order
            .HasMany(o => o.Items)
            .WithMany(i => i.Orders)
            .UsingEntity<OrderItem>(oi => oi.ToTable("OrdersItems")
                .Property(oi => oi.CreatedAt).HasDefaultValueSql("NOW()")
            );
        // order
        //     .HasMany(o => o.OrderItems)
        //     .WithOne(oi => oi.Order)
        //     .HasForeignKey(oi => oi.OrderId);
        
        
        
        order
            .HasOne(o => o.Store)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.StoreId);

        order
            .HasOne(o => o.Consumer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.ConsumerId);

        order
            .HasOne(o => o.Status)
            .WithMany(os => os.Orders)
            .HasForeignKey(o => o.ConsumerId);

        order
            .Property(o => o.Price)
            .HasPrecision(2, 10)
            .IsRequired();

        order
            .Property(o => o.DateDelivered)
            .HasDefaultValue(null);

        var orderStatus = modelBuilder.Entity<OrderStatus>();

        orderStatus.Property(os => os.Status)
            .HasMaxLength(50)
            .IsRequired();

        var item = modelBuilder.Entity<Item>();

        item
            .HasOne(i => i.Type)
            .WithMany(it => it.Items)
            .HasForeignKey(i => i.TypeId);

        // item
        //     .HasMany(i => i.OrderItems)
        //     .WithOne(oi => oi.Item)
        //     .HasForeignKey(oi => oi.ItemId);

        item
            .Property(i => i.Description)
            .HasMaxLength(100);

        item
            .Property(i => i.Name)
            .HasMaxLength(50)
            .IsRequired();

        item
            .Property(i => i.Price)
            .HasPrecision(2, 10)
            .IsRequired();

        item
            .Property(i => i.Stock)
            .IsRequired();

        var additionalServices = modelBuilder.Entity<AdditionalServices>();

        additionalServices
            .Property(asvc => asvc.Price)
            .HasPrecision(2, 10)
            .IsRequired();

        additionalServices
            .Property(asvc => asvc.Type)
            .HasMaxLength(50)
            .IsRequired();

        additionalServices
            .Property(asvc => asvc.Service)
            .IsRequired();

        var itemType = modelBuilder.Entity<ItemType>();

        itemType
            .Property(it => it.Type)
            .HasMaxLength(50)
            .IsRequired();

        itemType
            .Property(it => it.Tax)
            .IsRequired();
        

        // Addresses
modelBuilder.Entity<Address>().HasData(
    // Add 10 more Address instances here
    new Address { Id = 1, CEP = "56789012", Number = 309, City = "Chicago", State = "Illinois", Street = "Michigan Ave", UF = "IL" },
    new Address { Id = 2, CEP = "67890123", Number = 412, City = "Portland", State = "Oregon", Street = "Pearl St", UF = "OR" },
    new Address { Id = 3, CEP = "78901234", Number = 523, City = "Phoenix", State = "Arizona", Street = "Desert Ave", UF = "AZ" },
    new Address { Id = 4, CEP = "89012345", Number = 634, City = "Miami", State = "Florida", Street = "Ocean Dr", UF = "FL" },
    new Address { Id = 5, CEP = "90123456", Number = 745, City = "Nashville", State = "Tennessee", Street = "Music Rd", UF = "TN" },
    new Address { Id = 6, CEP = "12345678", Number = 123, City = "San Francisco", State = "California", Street = "Market St", UF = "CA" },
    new Address { Id = 7, CEP = "87654321", Number = 456, City = "Boston", State = "Massachusetts", Street = "Commonwealth Ave", UF = "MA" },
    new Address { Id = 8, CEP = "23456789", Number = 789, City = "Seattle", State = "Washington", Street = "Pine St", UF = "WA" },
    new Address { Id = 9, CEP = "34567890", Number = 101, City = "Austin", State = "Texas", Street = "6th Street", UF = "TX" },
    new Address { Id = 10, CEP = "45678901", Number = 210, City = "Denver", State = "Colorado", Street = "Broadway St", UF = "CO" },
    new Address { Id = 11, CEP = "56789012", Number = 309, City = "Chicago", State = "Illinois", Street = "Michigan Ave", UF = "IL" },
    new Address { Id = 12, CEP = "67890123", Number = 412, City = "Portland", State = "Oregon", Street = "Pearl St", UF = "OR" },
    new Address { Id = 13, CEP = "78901234", Number = 523, City = "Phoenix", State = "Arizona", Street = "Desert Ave", UF = "AZ" },
    new Address { Id = 14, CEP = "89012345", Number = 634, City = "Miami", State = "Florida", Street = "Ocean Dr", UF = "FL" },
    new Address { Id = 15, CEP = "90123456", Number = 745, City = "Nashville", State = "Tennessee", Street = "Music Rd", UF = "TN" },
new Address { Id = 16, CEP = "12345678", Number = 123, City = "San Francisco", State = "California", Street = "Market St", UF = "CA" },
new Address { Id = 17, CEP = "87654321", Number = 456, City = "Boston", State = "Massachusetts", Street = "Commonwealth Ave", UF = "MA" },
new Address { Id = 18, CEP = "23456789", Number = 789, City = "Seattle", State = "Washington", Street = "Pine St", UF = "WA" },
new Address { Id = 19, CEP = "34567890", Number = 101, City = "Austin", State = "Texas", Street = "6th Street", UF = "TX" },
new Address { Id = 20, CEP = "45678901", Number = 210, City = "Denver", State = "Colorado", Street = "Broadway St", UF = "CO" }

);





// AdditionalServices
modelBuilder.Entity<AdditionalServices>().HasData(
    // Add 10 more AdditionalServices instances here
    new AdditionalServices { Id = 4, Price = 6.99, Type = "Shipping", Service = "Standard Ground Shipping" },
    new AdditionalServices { Id = 5, Price = 12.00, Type = "Packaging", Service = "Premium Gift Wrapping Plus" },
    new AdditionalServices { Id = 6, Price = 3.50, Type = "Warranty", Service = "Extended Warranty Plus" },
    new AdditionalServices { Id = 7, Price = 7.99, Type = "Shipping", Service = "Two-Day Shipping" },
    new AdditionalServices { Id = 8, Price = 10.00, Type = "Packaging", Service = "Eco-Friendly Packaging" },
    new AdditionalServices { Id = 9, Price = 5.00, Type = "Warranty", Service = "Basic Warranty" },
    new AdditionalServices { Id = 10, Price = 9.99, Type = "Shipping", Service = "International Shipping" },
    new AdditionalServices { Id = 1, Price = 8.00, Type = "Packaging", Service = "Deluxe Gift Wrapping" },
    new AdditionalServices { Id = 2, Price = 4.50, Type = "Warranty", Service = "Extended Warranty Basic" },
    new AdditionalServices { Id = 3, Price = 14.99, Type = "Shipping", Service = "Express International Shipping" }
);

// ItemType
modelBuilder.Entity<ItemType>().HasData(
    // Add 10 more ItemType instances here
    new ItemType { Id = 4, Type = "Appliances", Tax = 15 },
    new ItemType { Id = 5, Type = "Jewelry", Tax = 7 },
    new ItemType { Id = 6, Type = "Sporting Goods", Tax = 8 },
    new ItemType { Id = 7, Type = "Home Accessories", Tax = 10 },
    new ItemType { Id = 8, Type = "Beauty Products", Tax = 6 },
    new ItemType { Id = 9, Type = "Food & Beverages", Tax = 0 },
    new ItemType { Id = 10, Type = "Office Supplies", Tax = 5 },
    new ItemType { Id = 1, Type = "Fragrances", Tax = 9 },
    new ItemType { Id = 2, Type = "Toiletries", Tax = 6 },
    new ItemType { Id = 3, Type = "Outdoor Gear", Tax = 8 }
);

// OrderStatus
modelBuilder.Entity<OrderStatus>().HasData(
    // Add 10 more OrderStatus instances here
    new OrderStatus { Id = 7, Status = "On Hold" },
    new OrderStatus { Id = 8, Status = "Backordered" },
    new OrderStatus { Id = 9, Status = "In Transit" },
    new OrderStatus { Id = 10, Status = "Out for Delivery" },
    new OrderStatus { Id = 1, Status = "Arrived at Destination" },
    new OrderStatus { Id = 2, Status = "Delayed" },
    new OrderStatus { Id = 3, Status = "Ready for Pickup" },
    new OrderStatus { Id = 4, Status = "Awaiting Payment" },
    new OrderStatus { Id = 5, Status = "Partially Shipped" },
    new OrderStatus { Id = 6, Status = "Refunded" }
);

modelBuilder.Entity<LegalCustomer>().HasData(
    new LegalCustomer
    {
        Id = 1,
        Name = "Legal Customer 1",
        CellPhone = "234-567-8901",
        HomePhone = "876-543-2109",
        Email = "legal1@example.com",
        Type = "legal",
        TypeDiscriminator = 1,
        Status = true,
        AddressId = 4,
        CNPJ = "12345678901234"
    },
    new LegalCustomer
    {
        Id = 2,
        Name = "Legal Customer 2",
        CellPhone = "234-567-8901",
        HomePhone = "876-543-2109",
        Email = "legal2@example.com",
        Type = "legal",
        TypeDiscriminator = 1,
        Status = true,
        AddressId = 5,
        CNPJ = "12345678901234"
    },
    new LegalCustomer
    {
        Id = 3,
        Name = "Legal Customer 3",
        CellPhone = "234-567-8901",
        HomePhone = "876-543-2109",
        Email = "legal3@example.com",
        Type = "legal",
        TypeDiscriminator = 1,
        Status = true,
        AddressId = 6,
        CNPJ = "12345678901234"
    },
    new LegalCustomer
    {
        Id = 4,
        Name = "Legal Customer 4",
        CellPhone = "234-567-8901",
        HomePhone = "876-543-2109",
        Email = "legal4@example.com",
        Type = "legal",
        TypeDiscriminator = 1,
        Status = true,
        AddressId = 7,
        CNPJ = "12345678901234"
    });

modelBuilder.Entity<NaturalCustomer>().HasData(
    new NaturalCustomer
    {
        Id = 5,
        Name = "Natural Customer 1",
        CellPhone = "345-678-9012",
        HomePhone = "765-432-1098",
        Email = "natural1@example.com",
        TypeDiscriminator = 2,
        Type = "natural",
        Status = true,
        AddressId = 8,
        CPF = "98765432109"
    },
    new NaturalCustomer
    {
        Id = 6,
        Name = "Natural Customer 2",
        CellPhone = "345-678-9012",
        HomePhone = "765-432-1098",
        Email = "natural2@example.com",
        TypeDiscriminator = 2,
        Type = "natural",
        Status = true,
        AddressId = 9,
        CPF = "98765432109"
    });

modelBuilder.Entity<Consumer>().HasData(
    new Consumer
    {
        Id = 1,
        Name = "Linus Torvalds",
        CellPhone = "123-456-7890",
        HomePhone = "987-654-3210",
        Email = "linus@example.com",
        Status = true,
        AddressId = 1,
        CPF = "73473943096"
    },
    new Consumer
    {
        Id = 2,
        Name = "rafa pava",
        CellPhone = "123-456-7890",
        HomePhone = "987-654-3210",
        Email = "rafa@pava.com",
        Status = true,
        AddressId = 2,
        CPF = "73473943096"
    },
    new Consumer
    {
        Id = 3,
        Name = "ti ago",
        CellPhone = "123-456-7890",
        HomePhone = "987-654-3210",
        Email = "ti@ago.com",
        Status = true,
        AddressId = 3,
        CPF = "73473943096"
    });

modelBuilder.Entity<Store>().HasData(
    new Store { Id = 1, Name = "Store 1", AddressId = 4, CustomerId = 1 },
    new Store { Id = 2, Name = "Store 2", AddressId = 5, CustomerId = 2 },
    new Store { Id = 3, Name = "Store 3", AddressId = 6, CustomerId = 3 },
    new Store { Id = 4, Name = "Store 4", AddressId = 7, CustomerId = 4 }
    );

// Item
modelBuilder.Entity<Item>().HasData(
    // Add 10 more Item instances here
    new Item { Id = 1, Name = "Refrigerator", Price = 799.99, Description = "Energy-efficient refrigerator", Stock = 25, StoreId = 1, TypeId = 1 },
    new Item { Id = 2, Name = "Diamond Necklace", Price = 1499.99, Description = "Exquisite diamond necklace", Stock = 10, StoreId = 2, TypeId = 2 },
    new Item { Id = 3, Name = "Basketball", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 4, Name = "Item 4", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 5, Name = "Item 5", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 6, Name = "Item 6", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 7, Name = "Item 7", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 8, Name = "Item 8", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 9, Name = "Item 9", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 3, TypeId = 3 },
    new Item { Id = 10, Name = "Item 10", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 11, Name = "Item 11", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 12, Name = "Item 12", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 13, Name = "Item 13", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 14, Name = "Item 14", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 15, Name = "Item 15", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 2, TypeId = 3 },
    new Item { Id = 16, Name = "Item 16", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 17, Name = "Item 17", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 18, Name = "Item 18", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 19, Name = "Item 19", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 20, Name = "Item 20", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 21, Name = "Item 21", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 22, Name = "Item 22", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 23, Name = "Item 23", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 24, Name = "Item 24", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 25, Name = "Item 25", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 26, Name = "Item 26", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 27, Name = "Item 27", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 28, Name = "Item 28", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 },
    new Item { Id = 29, Name = "Item 29", Price = 29.99, Description = "Official NBA basketball", Stock = 50, StoreId = 1, TypeId = 3 }
    

);



// StoreService
modelBuilder.Entity<StoreService>().HasData(
    // Add 10 more StoreService instances here
    new StoreService { StoreId = 1, ServicesId = 1, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 1, ServicesId = 2, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 2, ServicesId = 1, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 2, ServicesId = 2, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 3, ServicesId = 1, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 3, ServicesId = 2, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 4, ServicesId = 1, CreatedAt = DateTime.UtcNow },
    new StoreService { StoreId = 4, ServicesId = 2, CreatedAt = DateTime.UtcNow });



// Consumer 1
// Consumer 1
modelBuilder.Entity<Order>().HasData(
    new Order { Id = 1, Price = 49.99, StoreId = 1, StatusId = 1, ConsumerId = 1, DateCreated = DateTime.UtcNow },
    new Order { Id = 2, Price = 29.99, StoreId = 1, StatusId = 2, ConsumerId = 1, DateCreated = DateTime.UtcNow },
    new Order { Id = 3, Price = 19.99, StoreId = 2, StatusId = 3, ConsumerId = 1, DateCreated = DateTime.UtcNow },
    new Order { Id = 4, Price = 39.99, StoreId = 2, StatusId = 1, ConsumerId = 2, DateCreated = DateTime.UtcNow },
    new Order { Id = 5, Price = 19.99, StoreId = 3, StatusId = 2, ConsumerId = 2, DateCreated = DateTime.UtcNow },
    new Order { Id = 6, Price = 59.99, StoreId = 4, StatusId = 3, ConsumerId = 2, DateCreated = DateTime.UtcNow },
    new Order { Id = 7, Price = 29.99, StoreId = 3, StatusId = 1, ConsumerId = 3, DateCreated = DateTime.UtcNow },
    new Order { Id = 8, Price = 49.99, StoreId = 4, StatusId = 2, ConsumerId = 3, DateCreated = DateTime.UtcNow },
    new Order { Id = 9, Price = 69.99, StoreId = 1, StatusId = 3, ConsumerId = 3, DateCreated = DateTime.UtcNow });

modelBuilder.Entity<OrderItem>().HasData(
    // new OrderItem { ItemId = 1, OrderId = 1, CreatedAt = DateTime.UtcNow },
    // new OrderItem { ItemId = 2, OrderId = 1, CreatedAt = DateTime.UtcNow },
    // new OrderItem { ItemId = 3, OrderId = 1, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 4, OrderId = 2, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 5, OrderId = 2, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 6, OrderId = 2, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 7, OrderId = 3, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 8, OrderId = 3, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 9, OrderId = 3, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 10, OrderId = 4, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 11, OrderId = 4, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 12, OrderId = 4, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 13, OrderId = 5, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 14, OrderId = 5, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 15, OrderId = 5, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 16, OrderId = 6, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 17, OrderId = 6, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 18, OrderId = 6, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 19, OrderId = 7, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 20, OrderId = 7, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 21, OrderId = 7, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 22, OrderId = 8, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 23, OrderId = 8, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 24, OrderId = 8, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 25, OrderId = 9, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 26, OrderId = 9, CreatedAt = DateTime.UtcNow },
    new OrderItem { ItemId = 27, OrderId = 9, CreatedAt = DateTime.UtcNow }
);

    base.OnModelCreating(modelBuilder);
    }

}