using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosAppABP.TodoRecords
{
    public class Todo : Entity<int>
    {
        public string Description { get; set; }

        public bool IsFullfilled { get; set; }
    }
}
