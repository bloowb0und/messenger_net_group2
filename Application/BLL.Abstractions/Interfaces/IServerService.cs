﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstractions.Interfaces
{
    public interface IServerService
    {
        Task<bool> CreateServerAsync(string name);

        Task<bool> DeleteServerAsync(Server server);

        Task<bool> AddUserAsync(Server server, User user);

        Task<bool> AddUsersAsync(Server server, IEnumerable<User> user);

        Task<bool> DeleteUserAsync(Server server, User user);

        Task<bool> DeleteUsersAsync(Server server, IEnumerable<User> user);

        Task SendInvitationAsync(Server server, User user);
    }
}
