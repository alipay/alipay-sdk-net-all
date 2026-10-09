using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckItemData Data Structure.
    /// </summary>
    [Serializable]
    public class CheckItemData : AopObject
    {
        /// <summary>
        /// 就检状态：TO_CHECK：项目待就检；CHECKED：项目已就检
        /// </summary>
        [XmlElement("check_status")]
        public string CheckStatus { get; set; }

        /// <summary>
        /// 检测项名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 外部商品编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
