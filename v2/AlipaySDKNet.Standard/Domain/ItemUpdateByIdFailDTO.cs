using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdateByIdFailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdateByIdFailDTO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝内部商品编码ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
