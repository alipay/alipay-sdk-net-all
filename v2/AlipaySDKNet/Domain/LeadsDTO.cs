using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsDTO : AopObject
    {
        /// <summary>
        /// BD团队名称
        /// </summary>
        [XmlElement("bd_dept_name")]
        public string BdDeptName { get; set; }

        /// <summary>
        /// BD姓名或花名
        /// </summary>
        [XmlElement("bd_name")]
        public string BdName { get; set; }

        /// <summary>
        /// BD工号
        /// </summary>
        [XmlElement("bd_work_no")]
        public string BdWorkNo { get; set; }

        /// <summary>
        /// 商机客户编码
        /// </summary>
        [XmlElement("crm_customer_id")]
        public string CrmCustomerId { get; set; }

        /// <summary>
        /// 商机客户名称
        /// </summary>
        [XmlElement("crm_customer_name")]
        public string CrmCustomerName { get; set; }

        /// <summary>
        /// 商机部署方式CODE
        /// </summary>
        [XmlElement("deploy_type")]
        public string DeployType { get; set; }

        /// <summary>
        /// 部署类型枚举值
        /// </summary>
        [XmlElement("deploy_type_str")]
        public string DeployTypeStr { get; set; }

        /// <summary>
        /// 海图商机创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 海图商机修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 海图商机自增ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 海图商机编码
        /// </summary>
        [XmlElement("lead_id")]
        public string LeadId { get; set; }

        /// <summary>
        /// 商机SA姓名或花名
        /// </summary>
        [XmlElement("ob_sa_name")]
        public string ObSaName { get; set; }

        /// <summary>
        /// 商机SA工号
        /// </summary>
        [XmlElement("ob_sa_work_no")]
        public string ObSaWorkNo { get; set; }

        /// <summary>
        /// 商机阶段CODE
        /// </summary>
        [XmlElement("project_phase")]
        public string ProjectPhase { get; set; }

        /// <summary>
        /// 商机阶段枚举值
        /// </summary>
        [XmlElement("project_phase_name")]
        public string ProjectPhaseName { get; set; }

        /// <summary>
        /// 商机签约概率
        /// </summary>
        [XmlElement("sign_probability")]
        public string SignProbability { get; set; }

        /// <summary>
        /// 商机签约概率枚举值
        /// </summary>
        [XmlElement("sign_probability_str")]
        public string SignProbabilityStr { get; set; }
    }
}
