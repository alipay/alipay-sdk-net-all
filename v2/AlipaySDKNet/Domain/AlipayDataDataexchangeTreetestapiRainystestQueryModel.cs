using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeTreetestapiRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeTreetestapiRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("demo_0521")]
        public string Demo0521 { get; set; }

        /// <summary>
        /// 支付宝用户的测试。
        /// </summary>
        [XmlElement("demo_0525")]
        public string Demo0525 { get; set; }
    }
}
