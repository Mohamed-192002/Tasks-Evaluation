using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEvaluation.Core.Dtos
{
    public class BaseModelDto
    {
        public DateTime? EntryDate { get; set; }
        public DateTime? UpDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
