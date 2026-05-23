using System;
using System.Collections.Generic;
using System.Text;
using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Enums;
using NdpPortfolio.Core.Interfaces;

namespace NdpPortfolio.Infrastructure.Implementations.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly List<Project> _projects =
    [
        new Project
        {
            Id = 1,
            Title = "Portfolio Website",
            Description = "Personal portfolio built with ASP.NET MVC.",
            ProjectType = ProjectType.FullStack,
            IsLive = true,
            ImageUrl = "/images/portfolio.png",
            GitHubUrl = "https://github.com/NPlanche/NdpPorfolio",
            LiveUrl = "https://example.com",
            Technologies =
            [
                new Technology { Id = 1, Name = "C#" },
                new Technology { Id = 2, Name = "ASP.NET MVC" },
                new Technology { Id = 3, Name = "SQL Server" }
            ]
        },
        new Project
        {
            Id = 2,
            Title = "Task API",
            Description = "REST API for task management.",
            ProjectType = ProjectType.Api,
            IsLive = false,
            ImageUrl = "/images/api.png",
            GitHubUrl = "https://github.com/NPlanche/task-api",
            LiveUrl = string.Empty,
            Technologies =
            [
                new Technology { Id = 1, Name = ".NET" },
                new Technology { Id = 2, Name = "Swagger" }
            ]
        }
    ];

    public List<Project> GetAll()
    {
        return _projects;
    }

    public Project? GetById(int id)
    {
        return _projects.FirstOrDefault(p => p.Id == id);
    }

    public List<Project> GetProjectType(ProjectType projectType)
    {
        return _projects.Where(p => p.ProjectType == projectType).ToList();
    }

    public List<Project> GetLiveProjects()
    {
        return _projects.Where(p => p.IsLive).ToList();
    }

    
}