using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelInvoice Data Structure.
    /// </summary>
    [Serializable]
    public class HotelInvoice : AopObject
    {
        /// <summary>
        /// 发票模式 1=酒店开票 2=Ota提供发票
        /// </summary>
        [XmlElement("invoice_mode")]
        public long InvoiceMode { get; set; }

        /// <summary>
        /// 发票用途：中间用逗号分隔，代订房费，旅游费，差旅费，其他
        /// </summary>
        [XmlElement("invoice_purpose")]
        public string InvoicePurpose { get; set; }

        /// <summary>
        /// 支持的发票类型列表(英文逗号分割)： 1：增值税普通发票(纸质)， 2：增值税专用发票(纸质)， 3：增值税普通发票(电子)
        /// </summary>
        [XmlArray("invoice_type")]
        [XmlArrayItem("string")]
        public List<string> InvoiceType { get; set; }

        /// <summary>
        /// 1 支持预约开票，2不支持预约开票
        /// </summary>
        [XmlElement("order_invoice")]
        public string OrderInvoice { get; set; }

        /// <summary>
        /// 邮费提供方： 0：未设置  1：卖家承担， 2：买家承担（邮费到付）， 3：卖家承担（邮费￥XX）
        /// </summary>
        [XmlElement("postage_provider")]
        public string PostageProvider { get; set; }
    }
}
