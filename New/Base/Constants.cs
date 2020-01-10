using System.ComponentModel;

namespace New.Base
{
    public class Constants
    {

        /// <summary>
        /// 员工状态
        /// </summary>
        public enum EmployeeStatus
        {
            [Description("正常")]
            Normal = 1,
            [Description("离职")]
            Dimission = 2
        }

        
    }
}
