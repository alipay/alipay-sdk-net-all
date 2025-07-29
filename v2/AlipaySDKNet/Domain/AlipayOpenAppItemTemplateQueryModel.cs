using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 商品业务模式，租赁业务模式包含（短租：0；长租：1）
        /// </summary>
        [XmlElement("business_model")]
        public string BusinessModel { get; set; }

        /// <summary>
        /// 平台类目，填写的类目必须在类目表列出，只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类型，默认为实物商品
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
