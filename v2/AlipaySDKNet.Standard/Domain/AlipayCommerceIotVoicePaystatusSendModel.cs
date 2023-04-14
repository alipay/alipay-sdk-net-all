using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotVoicePaystatusSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotVoicePaystatusSendModel : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 1.为扫码提示音 2.为取消支付提示音
        /// </summary>
        [XmlElement("pay_status")]
        public long PayStatus { get; set; }

        /// <summary>
        /// 间连商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 触发提醒的时间戳
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
