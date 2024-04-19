using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionArgumentCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionArgumentCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建参数配置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
