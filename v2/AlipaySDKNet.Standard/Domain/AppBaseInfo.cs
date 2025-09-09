using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppBaseInfo : AopObject
    {
        /// <summary>
        /// 小程序的名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序归属pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
