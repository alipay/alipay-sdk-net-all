using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnchorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AnchorInfo : AopObject
    {
        /// <summary>
        /// 主播昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 平台ID
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
