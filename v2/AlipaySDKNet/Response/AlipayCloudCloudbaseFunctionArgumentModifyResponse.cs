using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionArgumentModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionArgumentModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改参数配置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
