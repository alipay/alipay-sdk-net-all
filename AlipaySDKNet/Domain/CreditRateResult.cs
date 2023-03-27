using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditRateResult Data Structure.
    /// </summary>
    [Serializable]
    public class CreditRateResult : AopObject
    {
        /// <summary>
        /// 信用等级范围最大值，范围是1-12，是闭区间
        /// </summary>
        [XmlElement("cr_rank")]
        public long CrRank { get; set; }

        /// <summary>
        /// 信用等级分档名称
        /// </summary>
        [XmlElement("cr_rank_title")]
        public string CrRankTitle { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 企业状态
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 信用等级数据
        /// </summary>
        [XmlElement("pass_status")]
        public string PassStatus { get; set; }
    }
}
