using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceOnlinetestsecondRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceOnlinetestsecondRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 参数测试
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }
    }
}
