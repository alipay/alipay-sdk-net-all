using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultFailReason Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultFailReason : AopObject
    {
        /// <summary>
        /// 咨询失败原因枚举编码
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 咨询失败原因的描述信息
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }
    }
}
