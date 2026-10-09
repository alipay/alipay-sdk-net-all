using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMgpEventTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMgpEventTriggerModel : AopObject
    {
        /// <summary>
        /// 业务类型，优先级低于event_code，如果同时传入event_code和biz_type则会优先使用event_code
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 事件码，优先级高于biz_type，如果同时传入event_code和biz_type则会优先使用event_code
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 唯一ID，自定义，用于进行幂等校验，如果不传则表示不进行幂等校验
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
