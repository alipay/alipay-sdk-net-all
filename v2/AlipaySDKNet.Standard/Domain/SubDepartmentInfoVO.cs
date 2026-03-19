using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubDepartmentInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SubDepartmentInfoVO : AopObject
    {
        /// <summary>
        /// 科室ID
        /// </summary>
        [XmlElement("depart_id")]
        public string DepartId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("depart_name")]
        public string DepartName { get; set; }
    }
}
