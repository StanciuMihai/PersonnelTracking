using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class TaskDetailDTO
    {
        public int EmployeeId { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TaskStateName { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskDeliveryDate { get; set; }

    }
}
