// See https://aka.ms/new-console-template for more information

using ImageManager.Services;

using ImageHandler handler = new();
await handler.LoadImageAsync("target.jpg");
handler.ToUltrawideMirrored();
await handler.SaveImageAsync("result1.jpg");