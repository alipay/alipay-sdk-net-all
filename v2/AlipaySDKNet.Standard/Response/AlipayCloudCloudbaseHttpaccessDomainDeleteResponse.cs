using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessDomainDeleteResponse : AopResponse
    {
        /// <summary>
        /// 是否删除成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
