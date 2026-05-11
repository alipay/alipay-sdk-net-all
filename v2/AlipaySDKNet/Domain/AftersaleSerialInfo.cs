using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleSerialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleSerialInfo : AopObject
    {
        /// <summary>
        /// 支付宝侧的凭证核销次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
