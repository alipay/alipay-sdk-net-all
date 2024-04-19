using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmsTemplateDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SmsTemplateDetail : AopObject
    {
        /// <summary>
        /// 模板审批状态。取值： AUDIT_STATE_INIT：审核中。 AUDIT_STATE_PASS：审核通过。 AUDIT_STATE_NOT_PASS：审核未通过，请在返回参数Reason中查看审核未通过原因。 AUDIT_STATE_CANCEL：取消审核。
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 短信模板的创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 审核备注: 如果审核状态为审核通过或审核中，参数Reason显示为“无审批备注”。 如果审核状态为审核未通过，参数Reason显示审核的具体原因。
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 短信模板CODE。
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板内容。
        /// </summary>
        [XmlElement("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型（推荐对外使用）。取值：  0：验证码短信。 1：通知短信。 2：推广短信。 3：国际/港澳台短信。
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
