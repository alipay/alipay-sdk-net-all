using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskVoucherInfo : AopObject
    {
        /// <summary>
        /// 当前门店优惠券核销笔数
        /// </summary>
        [XmlElement("shop_voucher_sales_amount")]
        public long ShopVoucherSalesAmount { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        [XmlElement("voucher_denomination")]
        public string VoucherDenomination { get; set; }

        /// <summary>
        /// 优惠券图标链接
        /// </summary>
        [XmlElement("voucher_icon_url")]
        public string VoucherIconUrl { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 优惠券核销笔数
        /// </summary>
        [XmlElement("voucher_sales_amount")]
        public long VoucherSalesAmount { get; set; }

        /// <summary>
        /// 优惠券模版id，唯一标识
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }

        /// <summary>
        /// 优惠券门槛
        /// </summary>
        [XmlElement("voucher_usage_threshold")]
        public string VoucherUsageThreshold { get; set; }
    }
}
