﻿using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace BlazorCrudDotNet8.AcceptanceTests.Admin;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public partial class GameAdminPages : PageTest
{
    [Test]
    public async Task MainNavigation()
    {
        await Page.GetByRole(AriaRole.Link, new() { Name = "Games" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Game List");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Create" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Game Creation");
        await Page.GetByTestId("gameAdminEditName").FillAsync("a game");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Create" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Game Modification");
        await Page.GetByTestId("gameAdminEditName").FillAsync("some game");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Modify" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Game Modification");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Remove" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Game List");
    }

    [SetUp]
    public async Task SetUp()
    {
        await Page.GotoAsync("http://localhost:5200");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Login" }).ClickAsync();
        await Expect(Page).ToHaveTitleAsync("Log in");
        await Page.GetByTestId("loginEmail").FillAsync("Admin1@BlazorCrudDotNet8.com");
        await Page.GetByTestId("loginPassword").FillAsync("Admin1@BlazorCrudDotNet8.com");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in" }).ClickAsync();
    }
}
