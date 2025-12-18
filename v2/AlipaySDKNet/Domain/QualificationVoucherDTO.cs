using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QualificationVoucherDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QualificationVoucherDTO : AopObject
    {
        /// <summary>
        /// 可用金额，单位元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 资格券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 资格券模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 券核销规则信息
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 锚定物资格券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
