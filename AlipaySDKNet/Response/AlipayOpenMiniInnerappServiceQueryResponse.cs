using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappServiceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序服务信息
        /// </summary>
        [XmlArray("mini_app_service_info_list")]
        [XmlArrayItem("mini_app_service_info")]
        public List<MiniAppServiceInfo> MiniAppServiceInfoList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
