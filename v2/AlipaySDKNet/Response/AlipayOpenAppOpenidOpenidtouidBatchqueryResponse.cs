using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidOpenidtouidBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenidOpenidtouidBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 不合法的openid列表
        /// </summary>
        [XmlArray("illegal_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalOpenIdList { get; set; }

        /// <summary>
        /// 查询转换后的uid、openid列表
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("open_id_value")]
        public List<OpenIdValue> UidList { get; set; }
    }
}
