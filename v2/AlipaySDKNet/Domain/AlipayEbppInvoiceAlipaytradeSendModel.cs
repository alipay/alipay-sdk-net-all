using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceAlipaytradeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceAlipaytradeSendModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 发票信息列表
        /// </summary>
        [XmlArray("invoice_info_list")]
        [XmlArrayItem("invoice_send_open_by_alipay_trade_no")]
        public List<InvoiceSendOpenByAlipayTradeNo> InvoiceInfoList { get; set; }

        /// <summary>
        /// 开票商户品牌简称
        /// </summary>
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 开票商户门店简称
        /// </summary>
        [XmlElement("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
