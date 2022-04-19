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
