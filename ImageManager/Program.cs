// See https://aka.ms/new-console-template for more information

using ImageManager.Services;

using ImageHandler handler = new("target.jpg");
handler.ToUltrawideMirrored();