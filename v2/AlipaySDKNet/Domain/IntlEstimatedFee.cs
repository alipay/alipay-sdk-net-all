using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntlEstimatedFee Data Structure.
    /// </summary>
    [Serializable]
    public class IntlEstimatedFee : AopObject
    {
        /// <summary>
        /// 运费(含报关费)，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("base_freight")]
        public long BaseFreight { get; set; }

        /// <summary>
        /// 折扣前合计(各项之和，单位分)
        /// </summary>
        [XmlElement("before_discount_fee")]
        public long BeforeDiscountFee { get; set; }

        /// <summary>
        /// 燃油附加费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("fuel_fee")]
        public long FuelFee { get; set; }

        /// <summary>
        /// 保价费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("insured_fee")]
        public long InsuredFee { get; set; }

        /// <summary>
        /// 优惠抵扣合计(单位分)
        /// </summary>
        [XmlElement("merchant_discount_fee")]
        public long MerchantDiscountFee { get; set; }

        /// <summary>
        /// 操作费(大件操作等)，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("operation_fee")]
        public long OperationFee { get; set; }

        /// <summary>
        /// 预估运费总价(折后 = before_discount_fee - merchant_discount_fee，单位分)
        /// </summary>
        [XmlElement("order_fee")]
        public long OrderFee { get; set; }

        /// <summary>
        /// 其他增值服务费(兜底)，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("other_addvalue_fee")]
        public long OtherAddvalueFee { get; set; }

        /// <summary>
        /// 其他运费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("other_freight")]
        public long OtherFreight { get; set; }

        /// <summary>
        /// 其他附加服务费(兜底)，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("other_surcharge_fee")]
        public long OtherSurchargeFee { get; set; }

        /// <summary>
        /// 超长超重费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("oversize_overweight_fee")]
        public long OversizeOverweightFee { get; set; }

        /// <summary>
        /// 包装费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("packaging_fee")]
        public long PackagingFee { get; set; }

        /// <summary>
        /// 偏远地区附加费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("remote_area_surcharge")]
        public long RemoteAreaSurcharge { get; set; }

        /// <summary>
        /// 敏货增值费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("sensitive_goods_addvalue_fee")]
        public long SensitiveGoodsAddvalueFee { get; set; }

        /// <summary>
        /// 超敏货增值费，单位分。支付方：寄件人
        /// </summary>
        [XmlElement("super_sensitive_addvalue_fee")]
        public long SuperSensitiveAddvalueFee { get; set; }
    }
}
