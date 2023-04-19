// See https://aka.ms/new-console-template for more information

using ImageManager.Services;

string filePath = "target.jpeg";
await using Stream fileStream = new FileStream(filePath, FileMode.Open);
Console.WriteLine(ImageValidationHandler.IsImageSupported(fileStream, filePath)
    ? "Image supported!"
    : "Image NOT supported...");

using ImageHandler handler = new();
await handler.LoadImageAsync("target.jpeg");
handler.ToUltrawideMirrored();
await handler.SaveImageAsync("result1.jpeg");