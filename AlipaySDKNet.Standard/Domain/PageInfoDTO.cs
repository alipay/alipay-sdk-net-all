using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PageInfoDTO : AopObject
    {
        /// <summary>
        /// code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [XmlElement("current_version")]
        public long CurrentVersion { get; set; }

        /// <summary>
        /// 编辑态版本
        /// </summary>
        [XmlElement("edit_version")]
        public long EditVersion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// code创建时间
        /// </summary>
        [XmlElement("gmt_create_code")]
        public string GmtCreateCode { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 修改人名字6
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 页面名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 所属活动dto
        /// </summary>
        [XmlElement("operation_task")]
        public OperationTaskDTO OperationTask { get; set; }

        /// <summary>
        /// 所属活动id
        /// </summary>
        [XmlElement("operation_task_id")]
        public long OperationTaskId { get; set; }

        /// <summary>
        /// 页面模版类型
        /// </summary>
        [XmlElement("page_template_type")]
        public string PageTemplateType { get; set; }

        /// <summary>
        /// 佩奇状态
        /// </summary>
        [XmlElement("peiqi_status")]
        public string PeiqiStatus { get; set; }

        /// <summary>
        /// 海豚权益code
        /// </summary>
        [XmlElement("promo_benefit_code")]
        public string PromoBenefitCode { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 页面渲染url
        /// </summary>
        [XmlElement("render_url")]
        public string RenderUrl { get; set; }

        /// <summary>
        /// 运行态版本
        /// </summary>
        [XmlElement("run_version")]
        public long RunVersion { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 所属模版code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 页面填入参数
        /// </summary>
        [XmlElement("template_params")]
        public string TemplateParams { get; set; }

        /// <summary>
        /// 租户code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
