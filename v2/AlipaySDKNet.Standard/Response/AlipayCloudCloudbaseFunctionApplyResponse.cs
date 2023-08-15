using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionApplyResponse : AopResponse
    {
        /// <summary>
        /// 执行云函数后返回对应函数执行结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
