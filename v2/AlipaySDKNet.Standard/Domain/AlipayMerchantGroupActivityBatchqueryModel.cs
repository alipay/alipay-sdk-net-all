using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupActivityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商家群活动类型列表，目前支持custom (自定义活动)
        /// </summary>
        [XmlArray("biz_type_list")]
        [XmlArrayItem("string")]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询条数，最大50条
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商家群活动内容状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
