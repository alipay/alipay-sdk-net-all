using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HuanxuUserHhhhhDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class HuanxuUserHhhhhDeleteModel : AopObject
    {
        /// <summary>
        /// fsdfsdfsd
        /// </summary>
        [XmlElement("aa")]
        public string Aa { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("add")]
        public string Add { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// asf
        /// </summary>
        [XmlElement("dd")]
        public string Dd { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
