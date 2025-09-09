using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataImSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝im消息id
        /// </summary>
        [XmlElement("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
