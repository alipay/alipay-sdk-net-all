using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliverySearchBoxRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliverySearchBoxRule : AopObject
    {
        /// <summary>
        /// 指定搜索直达区域
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }
    }
}
