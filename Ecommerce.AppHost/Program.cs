var builder = DistributedApplication.CreateBuilder(args);

var productApi = builder.AddProject<Projects.Ecommerce_ProductService>("apiservice-product");
var ordertApi = builder.AddProject<Projects.Ecommerce_OrderService>("apiservice-order");

builder.AddProject<Projects.Ecommerce_Web>("webfrontend")
    .WithReference(ordertApi)
    .WithReference(productApi);

builder.Build().Run();
