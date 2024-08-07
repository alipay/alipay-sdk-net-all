using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayInfoDTO : AopObject
    {
        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分隔，与enable_pay_channels互斥  <a href="https://opendocs.alipay.com/open/common/wifww7">渠道列表</a>
        /// </summary>
        [XmlElement("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分隔。  与disable_pay_channels互斥，支持传入的值：<a href="https://opendocs.alipay.com/open/common/wifww7">渠道列表</a>。  注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。
        /// </summary>
        [XmlElement("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 订单支付渠道，空值默认为支付宝支付
        /// </summary>
        [XmlElement("payment_biz_type")]
        public string PaymentBizType { get; set; }

        /// <summary>
        /// 支付方式，到付、无需支付等特殊场景下传入，到付和无需支付都会直接推进订单到已支付状态。
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
