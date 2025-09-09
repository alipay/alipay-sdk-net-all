using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleBlackList Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleBlackList : AopObject
    {
        /// <summary>
        /// 地址黑名单
        /// </summary>
        [XmlElement("address")]
        public RecyleBlackAddress Address { get; set; }

        /// <summary>
        /// 拉黑原因
        /// </summary>
        [XmlElement("forbidden_reason")]
        public string ForbiddenReason { get; set; }

        /// <summary>
        /// 拉黑时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("forbidden_time")]
        public string ForbiddenTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
