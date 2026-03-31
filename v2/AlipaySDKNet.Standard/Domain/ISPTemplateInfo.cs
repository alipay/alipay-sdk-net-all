using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ISPTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ISPTemplateInfo : AopObject
    {
        /// <summary>
        /// 模版有效期结束时间戳
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 图片文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 模版图片展位 电子海报:NORMAL_DISPLAY 支付结果页:PAY_SUCCESS_RESULT 商户信息海报:MERCHANT_INFO_POSTER
        /// </summary>
        [XmlElement("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 模版有效期开始时间戳
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

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

        /// <summary>
        /// 模版名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
