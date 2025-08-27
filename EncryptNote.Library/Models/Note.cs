namespace EncryptNote.Library.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string CreatedDate { get; set; } = string.Empty;
    public List<string> FilePaths { get; set; } = new List<string>();
    
    public string SimpleContent => Content.Length > 20 ? Content.Substring(0, 20) + "..." : Content;

    public string HeadImgPath
    {
        get
        {
            var imgPath = FilePaths.FirstOrDefault(x => x.EndsWith(".png") || x.EndsWith(".jpg") || x.EndsWith(".jpeg"));
            return imgPath ?? "Assets/Images/default.png";
        }
    }
    public List<string> FileNameList
    {
        get
        {
            return FilePaths.Select(x => Path.GetFileName(x)).ToList();
        }
    }
    
}