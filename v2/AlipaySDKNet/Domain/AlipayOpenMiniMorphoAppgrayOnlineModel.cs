using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppgrayOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppgrayOnlineModel : AopObject
    {
        /// <summary>
        /// 灰度策略
        /// </summary>
        [XmlElement("gray_strategy")]
        public string GrayStrategy { get; set; }

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
    }
}
