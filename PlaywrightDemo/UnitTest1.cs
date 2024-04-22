// using Microsoft.Playwright;
//
// namespace PlaywrightDemo;
//
// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }
//
//     [Test]
//     public async Task Test1()
//     {
//         //Playwright
//         using var playwright = await Playwright.CreateAsync();
//         //Browser
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false
//         });
//         //Page
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync("https://lk.mirea.ru/auth.php");
//         await page.FillAsync("#id_login", "geng.y.m@edu.mirea.ru");
//         await page.FillAsync("#id_password", "x3wTDwQ!WDtES6z");
//         await page.ScreenshotAsync(new PageScreenshotOptions
//         {
//             Path = "store_screen.jpg"
//         });
//         await page.ClickAsync("text=Авторизация");
//         var isExist = await page.Locator("text='Дистанционное обучение'").IsVisibleAsync();
//         Assert.IsTrue(isExist);
//     }
// }