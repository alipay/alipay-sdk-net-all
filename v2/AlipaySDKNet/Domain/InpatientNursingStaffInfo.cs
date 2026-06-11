using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientNursingStaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientNursingStaffInfo : AopObject
    {
        /// <summary>
        /// 安排人/护工姓名
        /// </summary>
        [XmlElement("assignee_name")]
        public string AssigneeName { get; set; }
    }
}
