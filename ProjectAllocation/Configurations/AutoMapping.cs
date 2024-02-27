using AutoMapper;
using ProjectAllocation.API.ViewModel;
using ProjectAllocation.Domain.Entities;

namespace ProjectAllocation.API.Configurations
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            #region Collaborator

            CreateMap<Collaborator, CollaboratorDTO>().ReverseMap();

            #endregion
        }
    }
}
