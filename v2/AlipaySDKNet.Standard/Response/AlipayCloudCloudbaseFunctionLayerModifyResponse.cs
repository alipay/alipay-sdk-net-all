using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLayerModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionLayerModifyResponse : AopResponse
    {
        /// <summary>
        /// 调整绑定层优先级结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
