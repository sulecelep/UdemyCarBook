﻿namespace UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class UpdateAboutCommand
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
