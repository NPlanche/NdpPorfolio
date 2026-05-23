using System;
using System.Collections.Generic;
using System.Text;
using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Enums;

namespace NdpPortfolio.Core.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        Project? GetById(int id);  
        List<Project> GetProjectType(ProjectType projectType);
        List<Project> GetLiveProjects();
    }
}
