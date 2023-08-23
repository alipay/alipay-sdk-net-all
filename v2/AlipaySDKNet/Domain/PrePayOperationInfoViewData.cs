using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrePayOperationInfoViewData Data Structure.
    /// </summary>
    [Serializable]
    public class PrePayOperationInfoViewData : AopObject
    {
        /// <summary>
        /// 渠道或者优惠的图像表达url
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 运营主体
        /// </summary>
        [XmlElement("operation_desc")]
        public string OperationDesc { get; set; }

        /// <summary>
        /// 运营文案描述
        /// </summary>
        [XmlElement("operation_tip")]
        public string OperationTip { get; set; }

        /// <summary>
        /// 运营信息:支付回传提升体验一致
        /// </summary>
        [XmlElement("pay_operation_info")]
        public string PayOperationInfo { get; set; }

        /// <summary>
        /// 运营活动定价
        /// </summary>
        [XmlElement("promo_price")]
        public string PromoPrice { get; set; }

        /// <summary>
        /// 营销类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 运营活动门槛信息
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }
    }
}
