using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardCycleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardCycleInfoDTO : AopObject
    {
        /// <summary>
        /// 支付宝用户签约协议号
        /// </summary>
        [XmlElement("alipay_deduct_agreement")]
        public string AlipayDeductAgreement { get; set; }

        /// <summary>
        /// 支付宝代扣产品码
        /// </summary>
        [XmlElement("alipay_deduct_product_code")]
        public string AlipayDeductProductCode { get; set; }

        /// <summary>
        /// 支付宝代扣场景码
        /// </summary>
        [XmlElement("alipay_deduct_scene")]
        public string AlipayDeductScene { get; set; }

        /// <summary>
        /// 关闭连续购买原因。
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 用户开通连续购买类型。
        /// </summary>
        [XmlElement("cycle_type")]
        public string CycleType { get; set; }

        /// <summary>
        /// 开通连续购买状态。
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }
    }
}
