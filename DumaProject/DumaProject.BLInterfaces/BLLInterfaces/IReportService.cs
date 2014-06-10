using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core.Entities;

namespace DumaProject.BLInterfaces.BLLInterfaces
{
    public interface IReportService : IService
    {
        void GenerateReportForMeeting(Meeting meeting, Commission commission,string type);
    }
}
