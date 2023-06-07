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
        /// 属性分组，具体的属性值可以参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
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
