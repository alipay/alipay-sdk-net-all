using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenidBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 非法的用户ID参数，涉及两种情况： 1. 不是有效的用户ID 2. 入参用户ID不在本工单审核的数据范围内，不支持查询
        /// </summary>
        [XmlArray("illegal_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalUserIdList { get; set; }

        /// <summary>
        /// 用户OpenID列表，每个元素包含用户的userId、openId和unionId，unionId可为空
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("open_id_value")]
        public List<OpenIdValue> OpenIdList { get; set; }
    }
}
