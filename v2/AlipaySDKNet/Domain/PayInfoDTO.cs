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
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割 注，与enable_pay_channels互斥 渠道列表：https://opendocs.alipay.com/open/common/wifww7
        /// </summary>
        [XmlElement("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：渠道列表：渠道列表：https://opendocs.alipay.com/open/common/wifww7。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。
        /// </summary>
        [XmlElement("enable_pay_channels")]
        public string EnablePayChannels { get; set; }
    }
}
