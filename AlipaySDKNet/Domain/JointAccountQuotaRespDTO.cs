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
