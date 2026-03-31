using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingTemplateCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模版状态 WAITTING_AUDIT(0, "WAITTING_AUDIT", "待审核", "待审核"),     AUDITING(1, "AUDITING", "审核中", "审核中"),     AUDIT_SUCCESS(2, "AUDIT_SUCCESS", "审核成功", "审核成功"),     AUDIT_FAIL(3, "AUDIT_FAIL", "审核失败", "审核失败"),     ONLINE(4, "ONLINE", "已上线", "上线操作"),     OFFLINE(5, "OFFLINE", "已失效", "下线操作"),     ONLINE_ERROR(6, "ONLINE_ERROR", "上线失败", "上线失败");
        /// </summary>
        [XmlElement("status_code")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
