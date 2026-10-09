using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayWeiboPucChargeResponse.
    /// </summary>
    public class AlipayWeiboPucChargeResponse : AopResponse
    {
        /// <summary>
        /// 返回页面内容
        /// </summary>
        [XmlElement("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
