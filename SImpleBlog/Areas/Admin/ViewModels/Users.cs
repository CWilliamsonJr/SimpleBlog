

using System.Collections.Generic;
using SimpleBlog.Models;

namespace SImpleBlog.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }
}