using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpMemberInfo : AopObject
    {
        /// <summary>
        /// 成员职务
        /// </summary>
        [XmlElement("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 成员姓名
        /// </summary>
        [XmlElement("member")]
        public string Member { get; set; }
    }
}
