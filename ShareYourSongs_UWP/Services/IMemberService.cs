using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareYourSongs_UWP.Models;

namespace ShareYourSongs_UWP.Services
{
    interface  IMemberService
    {
        Task<Member> Create(Member member);
        
    }
}
