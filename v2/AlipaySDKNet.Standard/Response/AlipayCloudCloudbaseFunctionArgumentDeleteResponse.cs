using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionArgumentDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionArgumentDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除参数配置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
