using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzServiceDetailCardExt Data Structure.
    /// </summary>
    [Serializable]
    public class YpzServiceDetailCardExt : AopObject
    {
        /// <summary>
        /// 陪诊师名称
        /// </summary>
        [XmlElement("attendant_name")]
        public string AttendantName { get; set; }
    }
}
