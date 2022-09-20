using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SlmAppInfo : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
