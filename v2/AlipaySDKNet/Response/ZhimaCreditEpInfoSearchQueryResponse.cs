using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpInfoSearchQueryResponse.
    /// </summary>
    public class ZhimaCreditEpInfoSearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 模糊搜索命中的企业列表
        /// </summary>
        [XmlArray("basic_info_models")]
        [XmlArrayItem("ep_search_basic_info")]
        public List<EpSearchBasicInfo> BasicInfoModels { get; set; }

        /// <summary>
        /// 分页中是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 分页用参数，代表请求结果的起始位置，默认1
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页用参数代表请求结果的总页面数
        /// </summary>
        [XmlElement("page_total")]
        public long PageTotal { get; set; }

        /// <summary>
        /// 命中的企业总数，如果没有则是0
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
