using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerVersionCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否创建成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
