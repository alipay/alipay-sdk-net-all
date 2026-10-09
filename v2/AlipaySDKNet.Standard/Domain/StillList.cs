using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StillList Data Structure.
    /// </summary>
    [Serializable]
    public class StillList : AopObject
    {
        /// <summary>
        /// 海报大图
        /// </summary>
        [XmlElement("olonk")]
        public string Olonk { get; set; }

        /// <summary>
        /// 海报缩略图
        /// </summary>
        [XmlElement("tlink")]
        public string Tlink { get; set; }
    }
}
