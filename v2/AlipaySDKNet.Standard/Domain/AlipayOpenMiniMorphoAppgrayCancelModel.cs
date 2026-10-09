using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppgrayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppgrayCancelModel : AopObject
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
    }
}
