# Widerpaper
Widerpaper is a Blazor Server Application to convert standard widescreen images to ultrawide.

![Widerpaper main page](https://github.com/BuenoVini/Widerpaper/assets/51279927/31891cfa-bb27-41bc-b302-6af6e3d00de9)

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
| ![Example 1 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/90d40676-14e3-4cd3-830a-5c30b5229fcc) | ![Example 1 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/fd7a59e9-cf6f-4f19-aa06-bb62254abde6) |
| ![Example 2 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/38775c7e-9d34-48ad-a42b-a787723b2d3d) | ![Example 2 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/4499212f-9620-4c3b-834d-8143ced0f4ca) |
| ![Example 3 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/f6b7edee-8af7-431a-8d4e-26b6bb034998) | ![Example 3 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/3595fa6e-fd0e-41f9-b44b-102672691c5e) |
| ![Example 4 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/b160e74d-d0c9-4eda-8537-d6da58b60f2f) | ![Example 4 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/fe52fc2c-edd2-42d0-85b4-8f5beb624956) |
| ![Example 5 Original](https://github.com/BuenoVini/Widerpaper/assets/51279927/cd0e5a27-3bef-424a-98dc-835c61d10d1e) | ![Example 5 Result](https://github.com/BuenoVini/Widerpaper/assets/51279927/19abba4c-0fa0-4cf1-a591-961eaef891e4) |

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
