using Backend.Entities;
using Backend.Repositories;

namespace Backend.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjects() => await _projectRepository.GetAllProjects();
        public async Task<Project?> GetProjectById(int id) => await _projectRepository.GetProjectById(id);
        public async Task AddProject(Project project) => await _projectRepository.AddProject(project);
        public async Task UpdateProject(Project project) => await _projectRepository.UpdateProject(project);
        public async Task DeleteProject(int id) => await _projectRepository.DeleteProject(id);
    }
}
