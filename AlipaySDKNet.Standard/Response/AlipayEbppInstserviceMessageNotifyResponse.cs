using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceMessageNotifyResponse.
    /// </summary>
    public class AlipayEbppInstserviceMessageNotifyResponse : AopResponse
    {
        /// <summary>
        /// 机构传入的手机号，户号，卡号等
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 通知结果状态，S/F 成功/失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
