using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessDomainModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
