using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs.Role;
using Application.Enums;

namespace Application.Interfaces.IServices
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAllAsync();
        
    }
}