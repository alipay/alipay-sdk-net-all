using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppTestInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppTestInfo : AopObject
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
        public long AppVersion { get; set; }
    }
}
