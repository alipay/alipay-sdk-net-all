using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthCloudresumeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthCloudresumeQueryModel : AopObject
    {
        /// <summary>
        /// 长效的认证令牌
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 交换云简历的单次token
        /// </summary>
        [XmlElement("once_token")]
        public string OnceToken { get; set; }
    }
}
