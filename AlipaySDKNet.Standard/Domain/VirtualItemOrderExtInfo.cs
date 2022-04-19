using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VirtualItemOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VirtualItemOrderExtInfo : AopObject
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("notify_app_id")]
        public string NotifyAppId { get; set; }
    }
}
