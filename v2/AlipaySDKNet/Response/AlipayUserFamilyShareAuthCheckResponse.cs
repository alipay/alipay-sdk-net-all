using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFamilyShareAuthCheckResponse.
    /// </summary>
    public class AlipayUserFamilyShareAuthCheckResponse : AopResponse
    {
        /// <summary>
        /// 指定资源下这两个用户是否存在共享关系
        /// </summary>
        [XmlElement("has_sharing_auth")]
        public bool HasSharingAuth { get; set; }
    }
}
