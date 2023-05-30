using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUserpagequeryQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUserpagequeryQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的用户信息列表
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_user_info")]
        public List<OpenApiUserInfo> BizData { get; set; }

        /// <summary>
        /// 页总数
        /// </summary>
        [XmlElement("page_count")]
        public long PageCount { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
