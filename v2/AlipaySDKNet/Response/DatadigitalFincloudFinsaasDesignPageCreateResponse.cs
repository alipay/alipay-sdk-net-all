using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功的返回值
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("page_id")]
        public long PageId { get; set; }

        /// <summary>
        /// page对象
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoDTO PageInfo { get; set; }
    }
}
