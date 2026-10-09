using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TasteMethod Data Structure.
    /// </summary>
    [Serializable]
    public class TasteMethod : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("taste_id")]
        public string TasteId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("taste_name")]
        public string TasteName { get; set; }
    }
}
