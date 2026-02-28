using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailFocusbenefitdataQueryResponse.
    /// </summary>
    public class AlipayCommerceRetailFocusbenefitdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据信息
        /// </summary>
        [XmlElement("data_list")]
        public string DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
