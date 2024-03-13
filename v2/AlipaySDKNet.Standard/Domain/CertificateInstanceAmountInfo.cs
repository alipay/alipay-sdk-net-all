using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateInstanceAmountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateInstanceAmountInfo : AopObject
    {
        /// <summary>
        /// 商家优惠金额，单位为元
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 商品标注的原价，单位为元。
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 用户实付金额，单位为元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 平台补贴金额，单位为元
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 商品售价去除商家订单优惠后的商家实收，未计算收单费率等，单位为元。
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 商品售卖的价格，单位为元。
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }
    }
}
