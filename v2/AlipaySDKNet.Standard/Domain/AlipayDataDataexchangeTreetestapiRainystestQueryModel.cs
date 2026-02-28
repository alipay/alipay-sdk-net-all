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
    }
}
