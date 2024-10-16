using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalOrderPayChannel Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalOrderPayChannel : AopObject
    {
        /// <summary>
        /// 通过该资产支付的金额；币种：人民币；单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 其他非支付宝支付的金额的支付渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }
    }
}
