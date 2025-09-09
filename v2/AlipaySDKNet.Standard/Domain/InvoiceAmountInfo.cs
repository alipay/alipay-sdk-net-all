using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceAmountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceAmountInfo : AopObject
    {
        /// <summary>
        /// 应付金额，单位：元
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 小程序云id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 已开票金额，单位：元
        /// </summary>
        [XmlElement("invoiced_amount")]
        public string InvoicedAmount { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// 实付金额，单位：元
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 可开票金额，单位：元
        /// </summary>
        [XmlElement("uninvoice_amount")]
        public string UninvoiceAmount { get; set; }
    }
}
