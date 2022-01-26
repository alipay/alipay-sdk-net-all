using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class AuthExtendParams : AopObject
    {
        /// <summary>
        /// 返佣参数
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
