using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Application.Implementations.Services
{
    public class WorkExperienceService : IWorkExperienceService
    {
        private readonly IWorkExperienceRepository _workExperienceRepository;

        public WorkExperienceService(IWorkExperienceRepository workExperienceRepository)
        {
            _workExperienceRepository = workExperienceRepository;
        }

        public List<WorkExperience> GetAllWorkExperinces()
        {
            return _workExperienceRepository.GetAll();
        }

        public WorkExperience? GetWorkExperience(int id)
        {
            return _workExperienceRepository.GetById(id);
        }
    }
}
