using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BianqueJumpChainConfig Data Structure.
    /// </summary>
    [Serializable]
    public class BianqueJumpChainConfig : AopObject
    {
        /// <summary>
        /// 应用key
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 跳链
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
