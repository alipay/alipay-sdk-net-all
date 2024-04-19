using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CashSummaryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CashSummaryDTO : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_document_no")]
        public string BizDocumentNo { get; set; }

        /// <summary>
        /// 付款失败金额(单位：各币种的"元")
        /// </summary>
        [XmlElement("pay_fail_amount")]
        public string PayFailAmount { get; set; }

        /// <summary>
        /// 付款成功金额(单位：各币种的"元")
        /// </summary>
        [XmlElement("pay_success_amount")]
        public string PaySuccessAmount { get; set; }

        /// <summary>
        /// 关联单据号
        /// </summary>
        [XmlElement("related_document_no")]
        public string RelatedDocumentNo { get; set; }

        /// <summary>
        /// 总金额(单位：各币种的"元")
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
