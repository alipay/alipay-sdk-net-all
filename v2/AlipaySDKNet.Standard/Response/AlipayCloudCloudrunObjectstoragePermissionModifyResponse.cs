using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstoragePermissionModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstoragePermissionModifyResponse : AopResponse
    {
        /// <summary>
        /// 实例的读权限
        /// </summary>
        [XmlElement("read_permission")]
        public string ReadPermission { get; set; }
    }
}
