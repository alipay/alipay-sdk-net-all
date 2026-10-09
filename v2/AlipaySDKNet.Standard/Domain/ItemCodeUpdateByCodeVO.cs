using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCodeUpdateByCodeVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCodeUpdateByCodeVO : AopObject
    {
        /// <summary>
        /// 原始商品编码, app方已经设置的商品编码
        /// </summary>
        [XmlElement("source_item_code")]
        public string SourceItemCode { get; set; }

        /// <summary>
        /// 目标商品编码, 新生成的, 要设置的商品编码
        /// </summary>
        [XmlElement("target_item_code")]
        public string TargetItemCode { get; set; }
    }
}
