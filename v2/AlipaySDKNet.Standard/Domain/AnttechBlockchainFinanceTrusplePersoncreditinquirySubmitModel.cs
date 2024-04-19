using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTrusplePersoncreditinquirySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTrusplePersoncreditinquirySubmitModel : AopObject
    {
        /// <summary>
        /// 资料附件列表
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("fin_attachment")]
        public List<FinAttachment> Attachments { get; set; }

        /// <summary>
        /// 被查人证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 被查人证件类型，RESIDENT 居民身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 被查人姓名
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 外部产品码
        /// </summary>
        [XmlElement("external_product_code")]
        public string ExternalProductCode { get; set; }

        /// <summary>
        /// 被查用户的外部用户唯一标识
        /// </summary>
        [XmlElement("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 查询原因
        /// </summary>
        [XmlElement("inquiry_reason")]
        public string InquiryReason { get; set; }

        /// <summary>
        /// 查询模板
        /// </summary>
        [XmlElement("inquiry_template")]
        public string InquiryTemplate { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 合作伙伴个人征信查询id，业务幂等字段
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
