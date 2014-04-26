using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duma_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Help());
            Application.Run(new MainMenu());
            Application.Run(new AddChangeEmployee());
            Application.Run(new ViewEmployee());
            Application.Run(new ViewEmployee1());
            Application.Run(new ViewEmployee2());
            Application.Run(new ViewEmployeeAddComission());
            Application.Run(new ViewEmployeeAddComission1());
            Application.Run(new ViewEmployeeAddMeeting());
            Application.Run(new ViewEmployeeAddComissionMeeting());
            Application.Run(new AddChangeComission());
            Application.Run(new ViewComission());
            Application.Run(new ViewComissionMembers());
            Application.Run(new ViewComissionMeetings());
            Application.Run(new ViewComissionHistory());
            Application.Run(new AddChangeMeeting());
            Application.Run(new ViewMeeting());
            Application.Run(new ViewMeetingMembers());
            Application.Run(new ViewMeetingComissions());


        }
        
    }
}
