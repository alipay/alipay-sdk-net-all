using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountQuotaRespDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountQuotaRespDTO : AopObject
    {
        /// <summary>
        /// 额度生效起始日期，精确到分钟。 格式：yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("custom_begin_date")]
        public string CustomBeginDate { get; set; }

        /// <summary>
        /// 额度失效结束日期，精确到分钟。 格式：yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("custom_end_date")]
        public string CustomEndDate { get; set; }

        /// <summary>
        /// 额度维度
        /// </summary>
        [XmlElement("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        [XmlElement("quota_remain")]
        public string QuotaRemain { get; set; }

        /// <summary>
        /// 展示额度剩余可用次数，-1表示无限次
        /// </summary>
        [XmlElement("quota_remain_count")]
        public string QuotaRemainCount { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 已用额度
        /// </summary>
        [XmlElement("quota_used")]
        public string QuotaUsed { get; set; }
    }
}
