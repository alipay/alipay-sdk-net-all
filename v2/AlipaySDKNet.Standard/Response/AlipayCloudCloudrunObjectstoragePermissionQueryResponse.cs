using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstoragePermissionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstoragePermissionQueryResponse : AopResponse
    {
        /// <summary>
        /// 实例的读权限
        /// </summary>
        [XmlElement("read_permission")]
        public string ReadPermission { get; set; }
    }
}
