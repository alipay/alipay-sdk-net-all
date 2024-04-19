using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageModifyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageModifyResponse : AopResponse
    {
        /// <summary>
        /// page_code
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 新的页面id
        /// </summary>
        [XmlElement("page_id")]
        public long PageId { get; set; }
    }
}
