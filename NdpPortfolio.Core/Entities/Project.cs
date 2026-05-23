using NdpPortfolio.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Technology> Technologies { get; set; } = new();
        public ProjectType ProjectType { get; set; }
        public bool IsLive { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description);
        }
    }   
}
