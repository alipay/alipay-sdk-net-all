using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimResultPolicyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimResultPolicyInfo : AopObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("dplan_code")]
        public string DplanCode { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
