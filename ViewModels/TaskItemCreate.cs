using ReadyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadyTask.ViewModels
{
    public class TaskItemCreate {
        public TaskItem TaskItem { get; set; }
        public List<ReadyTaskUser> readyTaskUsers { get; set; }
    }
}
