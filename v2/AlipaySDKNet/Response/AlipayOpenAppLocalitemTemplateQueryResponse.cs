using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppLocalitemTemplateQueryResponse.
    /// </summary>
    public class AlipayOpenAppLocalitemTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 属性分组
        /// </summary>
        [XmlElement("attr")]
        public ItemAttrGroupVO Attr { get; set; }

        /// <summary>
        /// 商品类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
