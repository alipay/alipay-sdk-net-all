using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAuthorizeBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAuthorizeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 授权信息列表
        /// </summary>
        [XmlArray("authorize_info_list")]
        [XmlArrayItem("group_authorize_v_o")]
        public List<GroupAuthorizeVO> AuthorizeInfoList { get; set; }

        /// <summary>
        /// 授权记录总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
