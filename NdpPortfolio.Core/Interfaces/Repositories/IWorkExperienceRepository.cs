using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Interfaces.Repositories
{
    public interface IWorkExperienceRepository
    {
        List<WorkExperience> GetAll();
        WorkExperience? GetById(int id);

    }
}
