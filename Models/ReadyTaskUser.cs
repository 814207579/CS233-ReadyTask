using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ReadyTask.Models {
    public class ReadyTaskUser : IdentityUser<int> {

        [PersonalData, StringLength(20)]
        public string FirstName { get; set; }
        [PersonalData, StringLength(20)]
        public string LastName { get; set; }
        public List<TaskItem> AssignedTasks { get; set; }
    }
}
