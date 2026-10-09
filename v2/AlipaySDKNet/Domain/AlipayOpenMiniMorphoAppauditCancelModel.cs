using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppauditCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppauditCancelModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 闪蝶身份校验
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }
    }
}
