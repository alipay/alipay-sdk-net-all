using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBillItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBillItem : AopObject
    {
        /// <summary>
        /// 01 实收开票，02 应收开票
        /// </summary>
        [XmlElement("invoice_mode")]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部单据类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
