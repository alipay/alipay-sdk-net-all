using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarSeriesServicecodeQueryResponse.
    /// </summary>
    public class AlipayEcoMycarSeriesServicecodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务库服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
