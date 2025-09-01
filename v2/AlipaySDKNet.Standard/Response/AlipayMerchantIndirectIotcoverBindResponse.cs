using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectIotcoverBindResponse.
    /// </summary>
    public class AlipayMerchantIndirectIotcoverBindResponse : AopResponse
    {
        /// <summary>
        /// 非支付宝交易到账播报语料ID，仅入参中传入speech_content时会返回该值。
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
