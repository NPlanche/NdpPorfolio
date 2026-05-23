using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Interfaces.Services
{
    public  interface IProjectService
    {
        List<Project> GetAllProjects();
        Project? GetProjectById(int id);
        List<Project> GetProjectsByType(ProjectType projectType);
        List<Project> GetLiveProjects();
    }
}
