using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvEnvvarsSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvEnvvarsSetResponse : AopResponse
    {
        /// <summary>
        /// 设置全局环境变量结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
