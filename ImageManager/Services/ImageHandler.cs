namespace ImageManager.Services;

public class ImageHandler : IDisposable
{
    private Image<Rgba32>? _imageInput;
    private Image<Rgba32>? _imageOutput;

    public void Dispose()
    {
        _imageInput?.Dispose();
        _imageOutput?.Dispose();
    }

    public async Task LoadImageAsync(Stream fileStream)
    {
        _imageInput = await Image.LoadAsync<Rgba32>(fileStream);
        _imageOutput = CreateUltrawideImage(_imageInput.Height);
    }
    
    public async Task LoadImageAsync(string filePath)
    {
        _imageInput = await Image.LoadAsync<Rgba32>(filePath);
        _imageOutput = CreateUltrawideImage(_imageInput.Height);
    }

    private Image<Rgba32> CreateUltrawideImage(int baseHeight) => new(baseHeight * 21 / 9, baseHeight);

    public async Task SaveImageAsync(string destinationPath)
    {
        if (_imageOutput is null)
            throw new NullReferenceException();
        
        await _imageOutput.SaveAsync(destinationPath);
    }

    public void DeleteImage(string filePath) => File.Delete(filePath);

    public void ToUltrawideMirrored()
    {
        if (_imageInput is null || _imageOutput is null)
            throw new NullReferenceException();
        
        /* an odd image has one extra column of pixels on the right side. so it must be treated separately */
        bool isOddImage = (_imageOutput.Width - _imageInput.Width) % 2 != 0;
        
        /* the quantity of pixels to be mirrored copied to the side of the input image */
        int qtyPixelsToCopy = (_imageOutput.Width - _imageInput.Width) / 2;

        for (int y = 0; y < _imageInput.Height; y++)
        {
            for (int x = 0; x < _imageInput.Width; x++)
            {
                Rgba32 currentPixel = _imageInput[x, y];
                
                /* copy inside the main box */
                _imageOutput[x + qtyPixelsToCopy, y] = currentPixel;
                
                /* copy mirrored outside the main box */
                if (x < qtyPixelsToCopy) 
                {
                    /* left side of the main box */
                    _imageOutput[qtyPixelsToCopy - x - 1, y] = currentPixel;
                }
                else if (x >= _imageInput.Width - qtyPixelsToCopy)   
                {
                    /* right side of the main box */
                    _imageOutput[_imageOutput.Width - (x - _imageInput.Width + qtyPixelsToCopy) - 1, y] = currentPixel;
                }

                /* fill missing pixel if this is an odd image */
                if (isOddImage)
                    _imageOutput[qtyPixelsToCopy + _imageInput.Width, y] = _imageInput[_imageInput.Width - 1, y];
            }
        }
    }
}