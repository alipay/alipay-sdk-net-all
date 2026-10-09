using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceReturntoantRainySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceReturntoantRainySyncModel : AopObject
    {
        /// <summary>
        /// 测试而已
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }
    }
}
