using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportBikeRightsTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportBikeRightsTriggerModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 流水号，用来查询日志、幂等判断
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 单车券：bike， 助力车券：ebike
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
