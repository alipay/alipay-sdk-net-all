using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockPokerChipSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockPokerChipSendModel : AopObject
    {
        /// <summary>
        /// 筹码数值，单位个
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// poker活动ID
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// poker筹码code
        /// </summary>
        [XmlElement("chip_code")]
        public string ChipCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单号，幂等用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 参数列表，用来控制筹码发放的内容
        /// </summary>
        [XmlArray("param")]
        [XmlArrayItem("kv")]
        public List<Kv> Param { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [XmlElement("trigger_time")]
        public string TriggerTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
