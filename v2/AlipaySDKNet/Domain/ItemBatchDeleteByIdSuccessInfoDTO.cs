using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemBatchDeleteByIdSuccessInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBatchDeleteByIdSuccessInfoDTO : AopObject
    {
        /// <summary>
        /// 支付宝内部商品编码ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
