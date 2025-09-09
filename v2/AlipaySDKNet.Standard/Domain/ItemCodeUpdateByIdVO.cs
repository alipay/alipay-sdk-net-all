using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCodeUpdateByIdVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCodeUpdateByIdVO : AopObject
    {
        /// <summary>
        /// 要修改的商品的id
        /// </summary>
        [XmlElement("source_item_id")]
        public string SourceItemId { get; set; }

        /// <summary>
        /// 要修改成的商品code, 由app方自行生成
        /// </summary>
        [XmlElement("target_item_code")]
        public string TargetItemCode { get; set; }
    }
}
