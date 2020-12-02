using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoTokenCreateModel : AopObject
    {
        /// <summary>
        /// 闪蝶站点 ID
        /// </summary>
        [XmlElement("aid")]
        public string Aid { get; set; }

        /// <summary>
        /// 闪蝶侧用户身份唯一标识
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 闪蝶空间ID
        /// </summary>
        [XmlElement("sid")]
        public string Sid { get; set; }
    }
}
