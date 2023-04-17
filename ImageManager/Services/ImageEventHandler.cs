namespace ImageManager.Services;

public class ImageEventHandler
{
    public event EventHandler? ImageUploaded;
    
    public void OnImageUploaded() => ImageUploaded?.Invoke(this, EventArgs.Empty); 
}