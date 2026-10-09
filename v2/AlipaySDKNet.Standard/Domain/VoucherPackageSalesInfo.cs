using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageSalesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageSalesInfo : AopObject
    {
        /// <summary>
        /// 券包售卖预算，单位是份数
        /// </summary>
        [XmlElement("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 券包购买支付渠道 pcredit：花呗 creditCard：信用卡 credit_group：花呗与信用卡 为空则不限渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 券包购买链接
        /// </summary>
        [XmlElement("purchase_url")]
        public string PurchaseUrl { get; set; }

        /// <summary>
        /// 券包售卖期限内最大购买次数
        /// </summary>
        [XmlElement("sale_count_limit_in_period")]
        public long SaleCountLimitInPeriod { get; set; }

        /// <summary>
        /// 券包购买期限类型 NO：不限制  ALL：售卖时间内  DAY：天  WEEK：周  MONTH：月
        /// </summary>
        [XmlElement("sale_period_limit")]
        public string SalePeriodLimit { get; set; }

        /// <summary>
        /// 券包售卖价格，单位是元
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }
    }
}
