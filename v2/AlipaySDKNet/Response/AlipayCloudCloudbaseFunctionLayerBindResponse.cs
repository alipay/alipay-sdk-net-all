using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLayerBindResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionLayerBindResponse : AopResponse
    {
        /// <summary>
        /// 层绑定结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
