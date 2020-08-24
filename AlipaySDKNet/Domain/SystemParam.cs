using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SystemParam Data Structure.
    /// </summary>
    [Serializable]
    public class SystemParam : AopObject
    {
        /// <summary>
        /// 业务功能类型
        /// </summary>
        [XmlElement("function")]
        public string Function { get; set; }

        /// <summary>
        /// 业务合作伙伴
        /// </summary>
        [XmlElement("partner")]
        public string Partner { get; set; }

        /// <summary>
        /// 系统幂等请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
