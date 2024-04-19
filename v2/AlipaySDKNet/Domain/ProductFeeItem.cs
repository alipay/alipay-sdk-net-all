using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductFeeItem Data Structure.
    /// </summary>
    [Serializable]
    public class ProductFeeItem : AopObject
    {
        /// <summary>
        /// 计费项列表
        /// </summary>
        [XmlArray("fee_items")]
        [XmlArrayItem("fee_item")]
        public List<FeeItem> FeeItems { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
