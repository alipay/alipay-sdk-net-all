using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageQueryResponse : AopResponse
    {
        /// <summary>
        /// pageCode
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 页面id
        /// </summary>
        [XmlElement("page_id")]
        public long PageId { get; set; }

        /// <summary>
        /// 页面详情
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
