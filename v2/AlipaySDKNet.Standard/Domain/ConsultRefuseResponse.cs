using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultRefuseResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultRefuseResponse : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 拒绝编码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝文案
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }
    }
}
