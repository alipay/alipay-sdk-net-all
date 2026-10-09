using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Operator Data Structure.
    /// </summary>
    [Serializable]
    public class Operator : AopObject
    {
        /// <summary>
        /// 工号 示例--蚂蚁内部：258900      外包：WB813544
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 花名 示例--蚂蚁内部：克礼     外包：汪彬
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }
    }
}
