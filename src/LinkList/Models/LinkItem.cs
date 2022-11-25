namespace LinkList.Models;

public class LinkItem
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public List<Tag> Tags { get; set; }

    public void AddTag(string name)
    {
        if (!Tags.Any(x => x.Equals(name)))
        {
            Tag newTag = new(name);
            Tags.Add(newTag);
        }
    }

    public LinkItem()
    {
        Id = Guid.NewGuid();
        Tags = new();
        Name = string.Empty;
        Url = string.Empty;
        ImageUrl = string.Empty;
    }

    public LinkItem(string name, string url) : this()
    {
        Name = name;
        Url = url;
    }

    public LinkItem(string name, string url, string imageUrl) : this(name, url)
    {
        ImageUrl = imageUrl;
    }
}