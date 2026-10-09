using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalPermissionQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalPermissionQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否含有权限
        /// </summary>
        [XmlElement("auth_flag")]
        public bool AuthFlag { get; set; }
    }
}
