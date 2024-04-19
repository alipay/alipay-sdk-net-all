using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidUidtoopenidBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenidUidtoopenidBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户OpenID列表，每个元素包含用户的userId、openId和unionId，unionId可为空
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("open_id_value")]
        public List<OpenIdValue> OpenIdList { get; set; }
    }
}
