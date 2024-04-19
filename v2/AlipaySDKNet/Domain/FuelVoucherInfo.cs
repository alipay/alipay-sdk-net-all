using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FuelVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FuelVoucherInfo : AopObject
    {
        /// <summary>
        /// 券归属的活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 互斥传:EXCLUSION，叠加传:SUPERPOSE
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 支付宝出资部分的金额 单位分
        /// </summary>
        [XmlElement("alipay_amount")]
        public long AlipayAmount { get; set; }

        /// <summary>
        /// 券的面额 单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商家出资的金额 单位分
        /// </summary>
        [XmlElement("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// 订单使用的券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
