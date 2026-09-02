using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProofInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProofInfo : AopObject
    {
        /// <summary>
        /// 资金证明材料url列表
        /// </summary>
        [XmlArray("fund_proofs_url")]
        [XmlArrayItem("string")]
        public List<string> FundProofsUrl { get; set; }

        /// <summary>
        /// 资金类型：加盟关系 01、集团关系 02、商圈关系 03
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 法人身份证正面证件
        /// </summary>
        [XmlElement("legal_cert_image")]
        public string LegalCertImage { get; set; }

        /// <summary>
        /// 法人身份证反面证件
        /// </summary>
        [XmlElement("legal_cert_image_back")]
        public string LegalCertImageBack { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [XmlElement("org_cert_image")]
        public string OrgCertImage { get; set; }
    }
}
