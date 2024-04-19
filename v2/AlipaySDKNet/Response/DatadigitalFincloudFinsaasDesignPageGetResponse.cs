using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageGetResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageGetResponse : AopResponse
    {
        /// <summary>
        /// 页面code
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 页面详情
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
