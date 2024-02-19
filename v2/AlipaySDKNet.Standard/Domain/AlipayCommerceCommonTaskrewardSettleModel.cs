using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTaskrewardSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTaskrewardSettleModel : AopObject
    {
        /// <summary>
        /// 导购员的userId
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购员的openId
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 激励发放途径，ZFB代表由支付宝执行淘客激励发放，MERCHANT表示由商户自己发送激励，但需要调用此接口结束该交易单激励，MERCHANT_DISCARD商户判断不需要发放激励，告知支付宝侧结束激励任务，MERCHANT_WAIT状态告知支付宝侧该激励有效，是否激励在商户侧决定后调用此接口，传入其他途径参数选择
        /// </summary>
        [XmlElement("reward_way")]
        public string RewardWay { get; set; }

        /// <summary>
        /// 淘客领取任务的支付宝任务id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 货款分账模式下，标识对用户发放激励的时间
        /// </summary>
        [XmlElement("unfreeze_time")]
        public string UnfreezeTime { get; set; }

        /// <summary>
        /// 商户侧判定的有效交易金额
        /// </summary>
        [XmlElement("valid_trade_amount")]
        public string ValidTradeAmount { get; set; }
    }
}
