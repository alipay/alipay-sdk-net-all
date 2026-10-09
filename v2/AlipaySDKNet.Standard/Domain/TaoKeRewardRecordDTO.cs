using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaoKeRewardRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaoKeRewardRecordDTO : AopObject
    {
        /// <summary>
        /// 达成交易的用户openId
        /// </summary>
        [XmlElement("guided_open_id")]
        public string GuidedOpenId { get; set; }

        /// <summary>
        /// 达成交易的用户
        /// </summary>
        [XmlElement("guided_uid")]
        public string GuidedUid { get; set; }

        /// <summary>
        /// 淘客的支付宝号
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 淘客的支付宝openId号
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商户侧外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 激励金额
        /// </summary>
        [XmlElement("reward_amount")]
        public string RewardAmount { get; set; }

        /// <summary>
        /// 等待激励
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 淘客领取的任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }
    }
}
