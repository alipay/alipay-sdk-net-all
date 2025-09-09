using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourPoiQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTourPoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码值
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 门店点位信息查询结果数据
        /// </summary>
        [XmlElement("poim_info_data")]
        public PoimInfoQueryOpenapiResult PoimInfoData { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
