using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryDisplayInfo : AopObject
    {
        /// <summary>
        /// 副标题。
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }
    }
}
