using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeContractPartner Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeContractPartner : AopObject
    {
        /// <summary>
        /// 参与方类型（包括：OU、NAME、PID、CID、UID、 MID）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 根据参与类型来设置具体的值（如：type=NAME, value=网商银行；type=PID, value=2088xxxxxxxx）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
