using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportWorldDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportWorldDataSyncModel : AopObject
    {
        /// <summary>
        /// 业务数据，外部商户不消费，如：支付宝主站卡类型
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务请求标识，用来标识一次请求，同一 应用id同一场景值唯一
        /// </summary>
        [XmlElement("event_no")]
        public string EventNo { get; set; }

        /// <summary>
        /// 描述当前同步请求的事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 请求来源，由支付宝主站分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 需要同步的数据
        /// </summary>
        [XmlElement("sync_data")]
        public string SyncData { get; set; }

        /// <summary>
        /// 支付宝主站用户ID。涉及用户的请求时必填，用于LDC路由；其他请求可为空，路由至最近的RZONE
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
