using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityAppInfo : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
