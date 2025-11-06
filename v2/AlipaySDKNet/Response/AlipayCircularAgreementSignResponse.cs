using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCircularAgreementSignResponse.
    /// </summary>
    public class AlipayCircularAgreementSignResponse : AopResponse
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 代扣页面链接，与sign_channel关联
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
