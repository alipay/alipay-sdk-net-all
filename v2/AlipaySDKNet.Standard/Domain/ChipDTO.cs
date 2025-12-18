using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChipDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChipDTO : AopObject
    {
        /// <summary>
        /// 筹码数量，单位个
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// poker活动code
        /// </summary>
        [XmlElement("campaign_code")]
        public string CampaignCode { get; set; }

        /// <summary>
        /// poker活动ID
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 筹码的主键ID
        /// </summary>
        [XmlElement("chip_id")]
        public string ChipId { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 筹码兑换状态
        /// </summary>
        [XmlElement("exchange_status")]
        public string ExchangeStatus { get; set; }

        /// <summary>
        /// 筹码发放时间
        /// </summary>
        [XmlElement("issue_time")]
        public string IssueTime { get; set; }

        /// <summary>
        /// 筹码发放参数
        /// </summary>
        [XmlElement("param")]
        public Kv Param { get; set; }

        /// <summary>
        /// 筹码触发时间
        /// </summary>
        [XmlElement("trigger_time")]
        public string TriggerTime { get; set; }
    }
}
