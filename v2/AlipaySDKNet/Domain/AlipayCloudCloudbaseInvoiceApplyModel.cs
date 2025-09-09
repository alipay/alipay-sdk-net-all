using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseInvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice_title")]
        public InvoiceTitle InvoiceTitle { get; set; }

        /// <summary>
        /// 订单号列表
        /// </summary>
        [XmlArray("order_no_list")]
        [XmlArrayItem("string")]
        public List<string> OrderNoList { get; set; }
    }
}
