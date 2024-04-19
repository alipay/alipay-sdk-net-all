using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskGravityWorkflowCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskGravityWorkflowCreateModel : AopObject
    {
        /// <summary>
        /// 需要合规审批的举报特征表详细信息
        /// </summary>
        [XmlElement("auth_feature_tables")]
        public string AuthFeatureTables { get; set; }

        /// <summary>
        /// 待合规审核的样本表及其对应的字段详情信息
        /// </summary>
        [XmlElement("check_sample_tables")]
        public string CheckSampleTables { get; set; }

        /// <summary>
        /// 合规任务表的主键id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 项目的描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 统一登录的域账户
        /// </summary>
        [XmlElement("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 展示合作的机构信息
        /// </summary>
        [XmlElement("org_info")]
        public string OrgInfo { get; set; }

        /// <summary>
        /// 项目的主键id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目的名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 历史审批数据，供审核人来参考
        /// </summary>
        [XmlElement("review_history")]
        public string ReviewHistory { get; set; }
    }
}
