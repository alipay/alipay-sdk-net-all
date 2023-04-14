using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBrandcatalogBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBrandcatalogBatchqueryModel : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("biz_data")]
        public SearchBrandboxQueryCatalogRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作的具体类型
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
