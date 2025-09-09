using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidOpenidtounionidBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenidOpenidtounionidBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 不合法的openid列表
        /// </summary>
        [XmlArray("illegal_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalOpenIdList { get; set; }

        /// <summary>
        /// 查询转换后的unionid、openid列表
        /// </summary>
        [XmlArray("unionid_list")]
        [XmlArrayItem("open_value")]
        public List<OpenValue> UnionidList { get; set; }
    }
}
