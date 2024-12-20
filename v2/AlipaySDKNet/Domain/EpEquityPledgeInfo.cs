using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpEquityPledgeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpEquityPledgeInfo : AopObject
    {
        /// <summary>
        /// 企业股权出质标的
        /// </summary>
        [XmlElement("czbd")]
        public string Czbd { get; set; }

        /// <summary>
        /// 出质股权数额，单位万元
        /// </summary>
        [XmlElement("czgqe")]
        public string Czgqe { get; set; }

        /// <summary>
        /// 出质人
        /// </summary>
        [XmlElement("czr")]
        public string Czr { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [XmlElement("dj_time")]
        public string DjTime { get; set; }

        /// <summary>
        /// 登记编号
        /// </summary>
        [XmlElement("djbh")]
        public string Djbh { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 质权人
        /// </summary>
        [XmlElement("zqr")]
        public string Zqr { get; set; }
    }
}
