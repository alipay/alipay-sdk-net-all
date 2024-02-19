using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutOrderBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutOrderBizInfo : AopObject
    {
        /// <summary>
        /// 业务信息字段code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 业务字段描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 业务字段值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
