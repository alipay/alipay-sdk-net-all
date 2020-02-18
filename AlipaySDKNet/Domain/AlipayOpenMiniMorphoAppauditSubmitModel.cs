using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppauditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppauditSubmitModel : AopObject
    {
        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 闪蝶身份验证信息
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 2张应用截图
        /// </summary>
        [XmlElement("screen_shots")]
        public string ScreenShots { get; set; }
    }
}
