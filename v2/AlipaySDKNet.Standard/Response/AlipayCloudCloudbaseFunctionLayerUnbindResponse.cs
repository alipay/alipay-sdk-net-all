using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLayerUnbindResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionLayerUnbindResponse : AopResponse
    {
        /// <summary>
        /// 层解除绑定结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
