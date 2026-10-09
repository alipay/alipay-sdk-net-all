using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFifteen Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFifteen : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("must_case")]
        public string MustCase { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }
    }
}
