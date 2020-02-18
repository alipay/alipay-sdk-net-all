using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHufuAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务系统创建时传入的序列号
        /// </summary>
        [XmlElement("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// 接入业务系统生成虎符时传入的uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 接入业务系统传入的通过验证的用户信息
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }
    }
}
