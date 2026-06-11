using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeTreetestapiRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeTreetestapiRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的userId。sdsdsd
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("demo_0525_out")]
        public string Demo0525Out { get; set; }
    }
}
