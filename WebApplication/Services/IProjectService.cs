﻿using Backend.Entities;

namespace Backend.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project?> GetProjectById(int id);
        Task AddProject(Project project);
        Task UpdateProject(Project project);
        Task DeleteProject(int id);
    }
}
