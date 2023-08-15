using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExternalaccountBindDeleteResponse : AopResponse
    {
        /// <summary>
        /// 解绑结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
