using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceApitreefirstRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceApitreefirstRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 复杂类型无参数
        /// </summary>
        [XmlElement("demo_response")]
        public RainyComplexTypesTheFifteen DemoResponse { get; set; }
    }
}
