using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIifaadidCertInvalidResponse.
    /// </summary>
    public class AlipaySecurityProdIifaadidCertInvalidResponse : AopResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("bsn")]
        public string Bsn { get; set; }

        /// <summary>
        /// 响应结果数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
