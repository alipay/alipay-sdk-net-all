using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransEntrustCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransEntrustCloseModel : AopObject
    {
        /// <summary>
        /// CREDIT_SALE_REPAY
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID（委托支付打款场景必传）
        /// </summary>
        [XmlElement("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 业务产品码，委托支付传ENTRUSTED_PAYMENT_COLLECTION
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
