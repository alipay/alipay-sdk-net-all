using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskrewardSettleResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskrewardSettleResponse : AopResponse
    {
        /// <summary>
        /// 已发放的激励金额，单位元
        /// </summary>
        [XmlElement("published_amount")]
        public string PublishedAmount { get; set; }

        /// <summary>
        /// 激励金额，单位元
        /// </summary>
        [XmlElement("reward_amount")]
        public string RewardAmount { get; set; }

        /// <summary>
        /// 激励类型
        /// </summary>
        [XmlElement("reward_type")]
        public string RewardType { get; set; }

        /// <summary>
        /// 淘客领取任务在支付宝的任务id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 最大激励金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
