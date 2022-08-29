using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcsmartCommonAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RcsmartCommonAppInfo : AopObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文名称),与分配的app_token一起做调用系统合法性校验。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验。
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }
    }
}
