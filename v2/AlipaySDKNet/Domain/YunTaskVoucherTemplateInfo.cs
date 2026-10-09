using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskVoucherTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskVoucherTemplateInfo : AopObject
    {
        /// <summary>
        /// 模板创建时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 发放结束时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券模板发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 模版状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券模版名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
