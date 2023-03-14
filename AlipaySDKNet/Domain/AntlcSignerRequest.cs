using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntlcSignerRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AntlcSignerRequest : AopObject
    {
        /// <summary>
        /// 协议签约人员工名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 协议签约人员工号
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }
    }
}
