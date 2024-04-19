using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageApplyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageApplyResponse : AopResponse
    {
        /// <summary>
        /// 页面code
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 页面新的id
        /// </summary>
        [XmlElement("page_id")]
        public long PageId { get; set; }
    }
}
