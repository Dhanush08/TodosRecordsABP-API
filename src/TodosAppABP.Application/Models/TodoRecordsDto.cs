using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosAppABP.Models
{
    public class TodoRecordsDto : EntityDto<int>
    {
        public string Description { get; set; }

        public bool IsFullfilled { get; set; }
    }
}
