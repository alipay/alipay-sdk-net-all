using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiEnterpriseUserAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiEnterpriseUserAuthInfo : AopObject
    {
        /// <summary>
        /// 返回的登录授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
