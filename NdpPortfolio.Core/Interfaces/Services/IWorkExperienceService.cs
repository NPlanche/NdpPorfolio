using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Interfaces.Services
{
    public interface IWorkExperienceService
    {
        List<WorkExperience> GetAllWorkExperinces();
        WorkExperience? GetWorkExperience(int id);
    }
}
