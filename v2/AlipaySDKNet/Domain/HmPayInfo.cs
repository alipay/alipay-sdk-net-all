using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HmPayInfo : AopObject
    {
        /// <summary>
        /// 支付金额，单位：分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }
    }
}
