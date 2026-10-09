using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunEnvShareDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudrunEnvShareDeleteResponse : AopResponse
    {
        /// <summary>
        /// 对响应结果的描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
