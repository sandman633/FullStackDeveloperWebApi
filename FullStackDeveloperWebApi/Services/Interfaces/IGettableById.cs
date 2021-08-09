﻿using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Services
{
    /// <summary>
    /// Interface for getting entities by id.
    /// </summary>
    /// <typeparam name="TDto"></typeparam>
    public interface IGettableById<TDto>
    {
        /// <summary>
        /// Interface method for getting entities by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TDto> GetByIdAsync(int id);
    }
}