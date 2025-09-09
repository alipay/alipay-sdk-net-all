using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemBatchDeleteSuccessInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBatchDeleteSuccessInfoDTO : AopObject
    {
        /// <summary>
        /// OMS厂商商品编码, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
