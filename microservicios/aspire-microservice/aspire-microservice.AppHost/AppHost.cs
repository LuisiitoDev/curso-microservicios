var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AddAdult>("addadult");

builder.AddProject<Projects.AddChild>("addchild");

builder.AddProject<Projects.AddMember>("addmember");

builder.AddProject<Projects.GetAdultById>("getadultbyid");

builder.AddProject<Projects.GetAdults>("getadults");

builder.AddProject<Projects.GetChildById>("getchildbyid");

builder.AddProject<Projects.GetChildren>("getchildren");

builder.AddProject<Projects.PickAge>("pickage");

builder.Build().Run();
