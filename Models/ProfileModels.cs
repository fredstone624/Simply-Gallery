﻿using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Simply_Gallery.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public byte[] Image { get; set; }
        public string ImageMimeType { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public IQueryable<Picture> Pictures { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public byte[] UserImage { get; set; }
        public string ImageMimeType { get; set; }
        public IQueryable<Album> Albums { get; set; }
    }
}