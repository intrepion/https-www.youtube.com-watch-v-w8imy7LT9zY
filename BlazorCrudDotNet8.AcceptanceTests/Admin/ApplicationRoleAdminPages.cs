﻿using Bogus;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace BlazorCrudDotNet8.AcceptanceTests.Admin;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public partial class ApplicationRoleAdminPages : PageTest
{
    [Test]
    public async Task MainNavigation()
    {
        var faker = new Faker();
        string aRandomString = faker.Random.String2(10);
        string someRandomString = faker.Random.String2(10);
        await Page.GetByRole(AriaRole.Link, new() { Name = "Application Roles" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role Home");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Create New" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role Add");
        await Page.GetByLabel("Name:").FillAsync("aName" + aRandomString);
        await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role Add");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Cancel" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role Home");
        await Page.GetByRole(AriaRole.Link, new() { Name = "aName" + aRandomString, Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "Edit" }).ClickAsync();
        await Page.GetByLabel("Name:").FillAsync("someName" + someRandomString);
        await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role View");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Delete" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Confirm" }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "Back to Grid" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Application Role Home");
    }

    [SetUp]
    public async Task SetUp()
    {
        var baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
        if (string.IsNullOrEmpty(baseUrl))
        {
            baseUrl = "ClientUriPlaceholder";
        }
        await Page.GotoAsync(baseUrl);
        await Page.GetByRole(AriaRole.Link, new() { Name = "Login" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Log in");
        await Page.GetByTestId("loginEmail").FillAsync("Admin1@BlazorCrudDotNet8.com");
        await Page.GetByTestId("loginPassword").FillAsync("Admin1@BlazorCrudDotNet8.com");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in" }).ClickAsync();
    }

    [TearDown]
    public async Task TearDown()
    {
        await Page.GetByRole(AriaRole.Button, new() { Name = "Logout" }).ClickAsync();
    }
}
