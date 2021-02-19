using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountQuotaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountQuotaDTO : AopObject
    {
        /// <summary>
        /// 额度维度
        /// </summary>
        [XmlElement("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }
    }
}
