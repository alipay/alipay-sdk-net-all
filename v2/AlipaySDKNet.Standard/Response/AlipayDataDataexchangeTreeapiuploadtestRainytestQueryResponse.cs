using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeTreeapiuploadtestRainytestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeTreeapiuploadtestRainytestQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的1111。
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("ref")]
        public RainyPraviteTestForUploadComplexInfo Ref { get; set; }
    }
}
