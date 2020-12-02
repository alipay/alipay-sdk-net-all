using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherInfoVO : AopObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 劵创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 团油劵名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 劵模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 劵面额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 劵实例ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// ENABLED:可用；DISABLED:不可用;DELETE:删除状态
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
