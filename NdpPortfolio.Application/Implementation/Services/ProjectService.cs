using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Enums;
using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Application.Implementations.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAll();
        }

        public List<Project> GetLiveProjects()
        {
            return _projectRepository.GetLiveProjects();
        }

        public Project? GetProjectById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public List<Project> GetProjectsByType(ProjectType projectType)
        {
            return _projectRepository.GetProjectType(projectType);
        }
    }
}
