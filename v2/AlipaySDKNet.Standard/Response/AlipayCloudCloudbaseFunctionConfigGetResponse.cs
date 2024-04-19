using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionConfigGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionConfigGetResponse : AopResponse
    {
        /// <summary>
        /// 云函数配置
        /// </summary>
        [XmlElement("config")]
        public Config Config { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }
    }
}
