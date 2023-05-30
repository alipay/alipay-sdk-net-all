using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceTenantpagequeryQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceTenantpagequeryQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关租户信息
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_tenant_info")]
        public List<OpenApiTenantInfo> BizData { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [XmlElement("page_count")]
        public long PageCount { get; set; }

        /// <summary>
        /// 当前页码
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
