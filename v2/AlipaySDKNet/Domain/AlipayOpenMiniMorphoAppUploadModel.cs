using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppUploadModel : AopObject
    {
        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 闪蝶身份校验信息
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 基于源码创建场景下的源码信息
        /// </summary>
        [XmlElement("source")]
        public MorphoSource Source { get; set; }
    }
}
