﻿namespace BincomContactSessionAssignment3;
public class Gallery
{
    public int Id { get; set; }
    public string FileName { get; set; } = default!;
    public string FilePath { get; set; } = null!;
    public DateTime UploadDate { get; set; }
}