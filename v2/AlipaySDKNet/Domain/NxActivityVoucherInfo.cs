using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NxActivityVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NxActivityVoucherInfo : AopObject
    {
        /// <summary>
        /// 商品LOGO地址。
        /// </summary>
        [XmlElement("item_logo")]
        public string ItemLogo { get; set; }

        /// <summary>
        /// 券所属商户LOGO地址。
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 券所属商户名称。
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商品原价，单位为人民币元。
        /// </summary>
        [XmlElement("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 奖品ID。
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 优惠数值；unit为“元”时表示人民币元金额，unit为“折”时表示折扣值。
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 券使用门槛展示文案，文案中包含金额及单位，例如“满10元可用”。
        /// </summary>
        [XmlElement("threshold_amount_text")]
        public string ThresholdAmountText { get; set; }

        /// <summary>
        /// 优惠金额或折扣的单位，如元、折。
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 用户领取的券实例ID。
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称。
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
