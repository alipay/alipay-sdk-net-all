using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneProductSignConfirmResponse.
    /// </summary>
    public class AlipayInsSceneProductSignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
