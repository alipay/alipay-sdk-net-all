using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallItemSpecValueDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallItemSpecValueDTO : AopObject
    {
        /// <summary>
        /// 规格值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
