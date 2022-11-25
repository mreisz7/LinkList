namespace LinkList.Models;

public class Tag {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Tag(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public bool Equals(string tagName)
    {
        return Name == tagName;
    }
}