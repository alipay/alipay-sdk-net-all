using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemBatchDeleteByIdFailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBatchDeleteByIdFailInfoDTO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝内部平台商品编码ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
