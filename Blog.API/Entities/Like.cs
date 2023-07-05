﻿namespace Blog.API.Entities
{
    public class Like
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Post? Post { get; set; }
        public Guid PostId { get; set; }
    }
}

