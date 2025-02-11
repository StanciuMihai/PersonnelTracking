using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PositionDAO : EmployeeContext
    {
        public static void AddPosition(POSITION position)
        {
            try
            {
                db.POSITIONs.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PositionDTO> GetPositions()
        {
            try
            {
                var list = (from p in db.POSITIONs
                            join d in db.DEPARTMENTs on p.DepartmentId equals d.ID
                            select new
                            {
                                positionId = p.ID,
                                positionName = p.PositionName,
                                departmentName = d.DepartmentName,
                                departmentID = p.DepartmentId
                            }).OrderBy(x => x.positionId).ToList();

                List<PositionDTO> positionList = new List<PositionDTO>();
                foreach(var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionId;
                    dto.PositionName = item.positionName;
                    dto.DepartmentName = item.departmentName;
                    dto.DepartmentId = item.departmentID;
                    positionList.Add(dto);
                }
                return positionList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
