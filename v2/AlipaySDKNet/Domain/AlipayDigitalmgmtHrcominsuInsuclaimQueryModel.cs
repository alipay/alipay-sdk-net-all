using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcominsuInsuclaimQueryModel : AopObject
    {
        /// <summary>
        /// data_key+唯一+分发给供应商的加密 key，用于识别供应商类型+枚举值(无)+业务生成后，分发给供应商+特殊说明(无)
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }
    }
}
