using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoritegiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 收藏有礼查询用户对应小程序的查询结果列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("activity_query_result")]
        public List<ActivityQueryResult> ResultList { get; set; }
    }
}
