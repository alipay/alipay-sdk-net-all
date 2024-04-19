using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionEnvvarsSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionEnvvarsSetResponse : AopResponse
    {
        /// <summary>
        /// 设置环境变量结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
