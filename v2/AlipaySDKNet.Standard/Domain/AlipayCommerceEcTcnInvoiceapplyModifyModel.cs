using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceapplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTcnInvoiceapplyModifyModel : AopObject
    {
        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 开票失败原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [XmlElement("logistics_company_code")]
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
