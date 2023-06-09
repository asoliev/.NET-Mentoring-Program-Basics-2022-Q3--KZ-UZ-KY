﻿using System.Text;

namespace FileCabinet.Models
{
    public class BaseDocument
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DocumentType DocumentType { get; set; }

        public DateTime DatePublished { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Id - {Id}");
            sb.AppendLine($"Title - {Title}");
            sb.AppendLine($"DatePublished - {DatePublished}");

            return sb.ToString();
        }
    }
}