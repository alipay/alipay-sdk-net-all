using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAppauthQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户授权小程序列表
        /// </summary>
        [XmlArray("app_auth_list")]
        [XmlArrayItem("mini_app_auth_info")]
        public List<MiniAppAuthInfo> AppAuthList { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
