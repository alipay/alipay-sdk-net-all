using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataTwentyTwoQueryResponse.
    /// </summary>
    public class AlipayDataTwentyTwoQueryResponse : AopResponse
    {
        /// <summary>
        /// 出参id基础描述
        /// </summary>
        [XmlElement("return_id")]
        public string ReturnId { get; set; }

        /// <summary>
        /// 出参open_id基础描述
        /// </summary>
        [XmlElement("return_open_id")]
        public string ReturnOpenId { get; set; }
    }
}
