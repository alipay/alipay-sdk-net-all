using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractreviewApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossAntlescenterPartcontractreviewApplyModel : AopObject
    {
        /// <summary>
        /// 审核页面地址
        /// </summary>
        [XmlElement("audit_url")]
        public string AuditUrl { get; set; }

        /// <summary>
        /// 人工审核时，指定的审核人工号； 加签时指定的加签人工号
        /// </summary>
        [XmlElement("audit_work_no")]
        public string AuditWorkNo { get; set; }

        /// <summary>
        /// 验证公司名称list
        /// </summary>
        [XmlArray("company_list")]
        [XmlArrayItem("string")]
        public List<string> CompanyList { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 上传文件合同
        /// </summary>
        [XmlElement("other_contract_file_addr")]
        public AntlescenterFileDTO OtherContractFileAddr { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
