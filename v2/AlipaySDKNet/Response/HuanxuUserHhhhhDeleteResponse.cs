using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// HuanxuUserHhhhhDeleteResponse.
    /// </summary>
    public class HuanxuUserHhhhhDeleteResponse : AopResponse
    {
        /// <summary>
        /// fsdfsdfsd
        /// </summary>
        [XmlElement("aa")]
        public string Aa { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
