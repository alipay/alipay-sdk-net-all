using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdAuthInfo : AopObject
    {
        /// <summary>
        /// 应用注册的appName
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用注册的token
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 业务身份，统计使用
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }
    }
}
