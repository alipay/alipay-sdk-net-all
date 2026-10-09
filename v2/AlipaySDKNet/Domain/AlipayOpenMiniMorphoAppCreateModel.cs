using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoAppCreateModel : AopObject
    {
        /// <summary>
        /// 闪蝶创建应用的应用信息
        /// </summary>
        [XmlElement("application")]
        public MorphoCreateApp Application { get; set; }

        /// <summary>
        /// 闪蝶身份校验信息
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 闪蝶创建应用的源码信息
        /// </summary>
        [XmlElement("source")]
        public MorphoCreateSource Source { get; set; }

        /// <summary>
        /// 创建应用使用的模板的信息
        /// </summary>
        [XmlElement("template")]
        public MorphoTemplate Template { get; set; }
    }
}
