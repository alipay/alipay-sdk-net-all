using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBranchInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBranchInfo : AopObject
    {
        /// <summary>
        /// 分支机构社会统一信用代码
        /// </summary>
        [XmlElement("branch_cert_no")]
        public string BranchCertNo { get; set; }

        /// <summary>
        /// 企业分支机构名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 颁发机构
        /// </summary>
        [XmlElement("registry_agency")]
        public string RegistryAgency { get; set; }
    }
}
