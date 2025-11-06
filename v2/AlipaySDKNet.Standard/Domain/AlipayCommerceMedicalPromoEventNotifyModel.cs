using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPromoEventNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPromoEventNotifyModel : AopObject
    {
        /// <summary>
        /// 营销返佣服务的事件编码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 营销返佣服务的事件中文名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 营销返佣服务完成的时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 营销返佣服务所在医院的名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 营销返佣服务所在医院的统一社会信用编码
        /// </summary>
        [XmlElement("merchant_uscc")]
        public string MerchantUscc { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 营销返佣服务的服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
