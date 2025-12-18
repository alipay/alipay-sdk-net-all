using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterBenefitDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterBenefitDeleteModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("benefits_list")]
        [XmlArrayItem("string")]
        public List<string> BenefitsList { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 活动最小单元ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 方案类型
        /// </summary>
        [XmlElement("solution_type")]
        public string SolutionType { get; set; }
    }
}
