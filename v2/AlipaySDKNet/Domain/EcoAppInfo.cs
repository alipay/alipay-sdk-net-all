using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoAppInfo : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }
    }
}
