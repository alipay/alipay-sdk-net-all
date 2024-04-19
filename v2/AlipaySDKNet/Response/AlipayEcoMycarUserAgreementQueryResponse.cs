using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarUserAgreementQueryResponse.
    /// </summary>
    public class AlipayEcoMycarUserAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否进行消息通知 true:进行 fase:进行
        /// </summary>
        [XmlElement("message_activate")]
        public bool MessageActivate { get; set; }

        /// <summary>
        /// 是否已经高级认证 true：是 flase：不是
        /// </summary>
        [XmlElement("senior_certificated")]
        public bool SeniorCertificated { get; set; }
    }
}
