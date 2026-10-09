using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformOrderQueryModel : AopObject
    {
        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 是否间联商户(是间联传Y,其他可不填) 非签约pid调用时必传Y(默认N)
        /// </summary>
        [XmlElement("is_sub_merchant")]
        public string IsSubMerchant { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
