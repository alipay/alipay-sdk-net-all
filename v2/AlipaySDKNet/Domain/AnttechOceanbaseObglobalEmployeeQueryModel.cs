using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalEmployeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalEmployeeQueryModel : AopObject
    {
        /// <summary>
        /// 查询员工信息
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }
    }
}
