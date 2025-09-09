using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TapPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TapPayInfo : AopObject
    {
        /// <summary>
        /// 碰一下支付的支付介质类型，标识当前支付为碰一下支付
        /// </summary>
        [XmlElement("payment_medium_type")]
        public string PaymentMediumType { get; set; }

        /// <summary>
        /// 碰一下支付的碰一下共减优惠金额
        /// </summary>
        [XmlElement("total_discount_amount")]
        public string TotalDiscountAmount { get; set; }

        /// <summary>
        /// 碰一下支付的碰一下共减金额展示名称
        /// </summary>
        [XmlElement("total_discount_name")]
        public string TotalDiscountName { get; set; }
    }
}
