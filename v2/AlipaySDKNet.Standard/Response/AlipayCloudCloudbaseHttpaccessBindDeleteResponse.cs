using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessBindDeleteResponse : AopResponse
    {
        /// <summary>
        /// 是否删除成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
