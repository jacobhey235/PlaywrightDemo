using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://lk.mirea.ru/auth.php");
    }

    [Test]
    public async Task Test1()
    {
        await Page.FillAsync("#id_login", "geng.y.m@edu.mirea.ru");
        await Page.FillAsync("#id_password", "x3wTDwQ!WDtES6z");
        await Page.ClickAsync("text=Авторизация");
        await Expect(Page.Locator("text='Дистанционное обучение'")).ToBeVisibleAsync();
    }
}