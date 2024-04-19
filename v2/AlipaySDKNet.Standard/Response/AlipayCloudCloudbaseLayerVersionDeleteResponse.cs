using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerVersionDeleteResponse : AopResponse
    {
        /// <summary>
        /// 是否删除成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
