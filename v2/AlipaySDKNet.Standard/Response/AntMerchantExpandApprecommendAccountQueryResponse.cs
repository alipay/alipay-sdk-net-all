using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandApprecommendAccountQueryResponse.
    /// </summary>
    public class AntMerchantExpandApprecommendAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账号列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("string")]
        public List<string> List { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 单页行数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
