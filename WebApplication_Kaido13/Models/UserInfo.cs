using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Kaido13.Models
{
    public class UserInfo
    {
        /// <summary>
        /// ユーザID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ユーザ名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 組織ID
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// 組織
        /// </summary>
        public Organization Organization { get; set; }
    }
}
