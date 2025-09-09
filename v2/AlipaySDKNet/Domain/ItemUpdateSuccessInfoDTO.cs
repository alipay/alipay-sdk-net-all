using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdateSuccessInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdateSuccessInfoDTO : AopObject
    {
        /// <summary>
        /// OMS厂商商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
