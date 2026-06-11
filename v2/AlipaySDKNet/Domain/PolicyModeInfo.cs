using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyModeInfo : AopObject
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("dplan_name")]
        public string DplanName { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
