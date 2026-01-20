// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Teams.Plugins.AspNetCore.Extensions;
using Microsoft.Teams.Apps.Activities;

var builder = WebApplication.CreateBuilder(args);
builder.AddTeams();

var webApp = builder.Build();
var teamsApp = webApp.UseTeams(true);

teamsApp.OnMessage(async context =>
{
    await context.Send("echo from dotnet 🚀: " + context.Activity.Text);
});

webApp.Run();