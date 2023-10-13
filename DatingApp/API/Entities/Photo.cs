﻿namespace API.Entities;

public class Photo
{
    public int Id { get; set; }

    public string Url { get; set; }

    public bool IsMain { get; set; }

    public int PublicId { get; set; }
}