using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NdpPortfolio.Infrastructure.Implementations.Repositories
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private readonly List<WorkExperience> _workExperiences =
   [
       new WorkExperience
        {
            Id = 1,
            Title = "Software Developer",
            StartDate = new DateTime(2023, 1, 1),
            EndDate = new DateTime(2024, 12, 31)
        },
        new WorkExperience
        {
            Id = 2,
            Title = "Support Analyst",
            StartDate = new DateTime(2021, 6, 1),
            EndDate = new DateTime(2022, 12, 31)
        }
   ];
        public List<WorkExperience> GetAll()
        {
            return _workExperiences;
        }

        public WorkExperience? GetById(int id)
        {
            return _workExperiences.FirstOrDefault(x => x.Id == id);
        }
    }
}
