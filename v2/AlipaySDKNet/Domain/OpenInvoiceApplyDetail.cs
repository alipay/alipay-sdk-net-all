using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenInvoiceApplyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OpenInvoiceApplyDetail : AopObject
    {
        /// <summary>
        /// 单据总金额（元）
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 平台单据号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 单据开票金额（元）
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 平台单据所属人ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 平台单据所属人ID
        /// </summary>
        [XmlElement("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 平台单据所属人ID类型标识
        /// </summary>
        [XmlElement("platform_user_id_type")]
        public string PlatformUserIdType { get; set; }

        /// <summary>
        /// 关联单据号
        /// </summary>
        [XmlElement("related_bill_no")]
        public string RelatedBillNo { get; set; }
    }
}
