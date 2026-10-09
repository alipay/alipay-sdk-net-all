using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GrmProjectInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GrmProjectInfoDTO : AopObject
    {
        /// <summary>
        /// 附件地址
        /// </summary>
        [XmlArray("attachments_url")]
        [XmlArrayItem("string")]
        public List<string> AttachmentsUrl { get; set; }

        /// <summary>
        /// 延续项目编号
        /// </summary>
        [XmlElement("continue_project_code")]
        public string ContinueProjectCode { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("create")]
        public string Create { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [XmlElement("create_name")]
        public string CreateName { get; set; }

        /// <summary>
        /// 产品交付物及验收标准
        /// </summary>
        [XmlArray("critical_deliverable")]
        [XmlArrayItem("deliverable")]
        public List<Deliverable> CriticalDeliverable { get; set; }

        /// <summary>
        /// 项目描述目的及价值
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 项目结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 业务方代表工号
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 业务方代表名称
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 项目经理工号
        /// </summary>
        [XmlElement("pm")]
        public string Pm { get; set; }

        /// <summary>
        /// 项目经理名称
        /// </summary>
        [XmlElement("pm_name")]
        public string PmName { get; set; }

        /// <summary>
        /// PR提交人工号
        /// </summary>
        [XmlElement("pr_emp_id")]
        public string PrEmpId { get; set; }

        /// <summary>
        /// pr提交人姓名
        /// </summary>
        [XmlElement("pr_emp_name")]
        public string PrEmpName { get; set; }

        /// <summary>
        /// 业管平台立项编码
        /// </summary>
        [XmlElement("project_code")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 立项项目详情URL
        /// </summary>
        [XmlElement("project_detail_url")]
        public string ProjectDetailUrl { get; set; }

        /// <summary>
        /// 业管平台立项名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目结算类型
        /// </summary>
        [XmlElement("project_pay")]
        public string ProjectPay { get; set; }

        /// <summary>
        /// 项目时间表
        /// </summary>
        [XmlArray("project_time_sheet")]
        [XmlArrayItem("project_time_table")]
        public List<ProjectTimeTable> ProjectTimeSheet { get; set; }

        /// <summary>
        /// 业管平台立项类型大类
        /// </summary>
        [XmlElement("project_type")]
        public string ProjectType { get; set; }

        /// <summary>
        /// 工作量
        /// </summary>
        [XmlArray("project_workload")]
        [XmlArrayItem("workload")]
        public List<Workload> ProjectWorkload { get; set; }

        /// <summary>
        /// 服务地点
        /// </summary>
        [XmlElement("service_location")]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// 结算公式编码
        /// </summary>
        [XmlElement("settlement_formula_code")]
        public string SettlementFormulaCode { get; set; }

        /// <summary>
        /// 结算公式名称
        /// </summary>
        [XmlElement("settlement_formula_name")]
        public string SettlementFormulaName { get; set; }

        /// <summary>
        /// sla详情地址
        /// </summary>
        [XmlElement("sla_view_info")]
        public string SlaViewInfo { get; set; }

        /// <summary>
        /// 项目开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 立项金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 采购用途code
        /// </summary>
        [XmlElement("usage_code")]
        public string UsageCode { get; set; }
    }
}
