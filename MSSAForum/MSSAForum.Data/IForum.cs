using MSSAForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MSSAForum.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumUd, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
