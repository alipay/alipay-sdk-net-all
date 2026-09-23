using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoicetitleAlipaytradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoicetitleAlipaytradeQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

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
