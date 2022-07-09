using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Data.Requests.Contracts
{
    public class LoginResultDto
    {
        public string Token { get; set; }
        public string DisplayName { get; set; }
    }

}
