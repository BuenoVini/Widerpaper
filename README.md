# Widerpaper
Widerpaper is a Blazor Server Application to convert standard widescreen images to ultrawide.

![Widerpaper main page](https://github.com/BuenoVini/Widerpaper/assets/51279927/1e75f606-0b39-40d2-a9ec-386fe915f7e7)

A **widescreen** image has a 16:9 aspect ratio (_e.g._ 1920x1080) whereas an **ultra widescreen** image has 21:9 aspect ratio (_e.g._ 2560x1080).

## Main goal
This project aims to solve a recurring problem that I had when setting up a new ultrawide wallpaper on my personal computer. Usually, wallpaper images are in 16:9 aspect ratio, but when set on an ultrawide monitor, the image becomes either stretched, cropped, or zoomed.

Widerpaper tries to solve this problem by implementing an image mirror algorithm (designed by me) to extend the original 16:9 file to 21:9.

## Take away
Very much like my last two main projects [last.fm analyzer](https://github.com/BuenoVini/lastfm-analyzer) and [Sparkfly](https://github.com/BuenoVini/SparkflyBlazor), this repository is a way to showcase my ever-growing programming and Blazor skills.

**Topics learned:**
- JetBrains Rider
- .NET project solution
- Image manipulation in C# using [ImageSharp](https://sixlabors.com/products/imagesharp/)
- File signature validation
- Event handlers
- Blazor components states
- File uploading and downloading in Blazor

## Features
Widerpaper is a single page application that allows the user to upload an image by either selecting a file through a dialog window or dragging and dropping a file in the main box. The apps then uploads the image to the server to process it and allows the user to download the converted image.

### Results
Even though you can still see the mirrored effect on some images, I consider the results as pretty good overall!! Even better when the background of the image is more uniform or abstract.
| Before (16:9) | After (21:9) |
| --- | --- |
| ![Example 1 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/d0581c67-4724-4142-a293-499bd6e7cd30) | ![Example 1 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/40f23fd8-9f5e-4881-bcfd-5f970277d536) |
| ![Example 2 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/b81891c6-26a3-4f2a-8385-56eeb3351e1b) | ![Example 2 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/03f3349c-23dd-4c5b-afda-61a9188c1ce4) |
| ![Example 3 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/813a053b-5f38-4113-8f00-dec650e9de4c) | ![Example 3 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/088fb08e-520d-4128-8c14-0c28e96c8925) |
| ![Example 4 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/3c28f99a-6c71-4d49-bbd1-11a8462254b7) | ![Example 4 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/ef92f208-2334-4bb0-ae86-ff9dec9d64be) |
| ![Example 5 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/68d39e96-d222-4d49-a053-874b925af875) | ![Example 5 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/7f8338c5-2801-4a34-93ec-5937949461fd) |

## Contributing
You cannot modify nor redistribute this code without explicit permission.

This repository is for practicing my skills only and does not represent a final product.

## Credits and acknowledgement
Here is a collection of sources that helped me through development:
- ImageSharp documentation: https://docs.sixlabors.com/articles/imagesharp/?tabs=tabid-1
- Macoratti tutorial for drag and drop files in Blazor: https://www.macoratti.net/20/11/blz_upldrag1.htm
- Bootstrap documentation: https://getbootstrap.com/docs/5.3/getting-started/introduction/
- Event handlers in C#: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event

There are always those that incentivize me to create new projects and explore new ideas. I dedicate this project to my former coworkers that I am still in touch with and to Rafa who saw this project first and called it _"MAGICAL!"_.

## Next steps
The next feature that I would like to add is to convert this project into a [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui) application. So that I can more easily share this tool with friends and the world!

Unfortunately, MAUI is not yet available on Linux (https://learn.microsoft.com/en-us/dotnet/maui/supported-platforms) which is my current development environment, so I cannot build such project right now. But maybe in the near future!!
