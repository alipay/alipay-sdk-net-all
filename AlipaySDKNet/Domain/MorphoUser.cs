using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoUser Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoUser : AopObject
    {
        /// <summary>
        /// 闪蝶侧用户ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户花名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }
    }
}
