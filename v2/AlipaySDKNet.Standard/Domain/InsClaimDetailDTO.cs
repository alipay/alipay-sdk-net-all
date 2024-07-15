using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimDetailDTO : AopObject
    {
        /// <summary>
        /// 理赔金额(元)
        /// </summary>
        [XmlElement("claim_fee")]
        public string ClaimFee { get; set; }

        /// <summary>
        /// 责任编码
        /// </summary>
        [XmlElement("liability_code")]
        public string LiabilityCode { get; set; }

        /// <summary>
        /// 责任名称
        /// </summary>
        [XmlElement("liability_name")]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 结案原因
        /// </summary>
        [XmlElement("resolve_reason")]
        public string ResolveReason { get; set; }
    }
}
