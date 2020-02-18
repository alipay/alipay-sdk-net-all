using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUseridBymobileQueryResponse.
    /// </summary>
    public class AlipayUserUseridBymobileQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定手机号对应的支付宝userId列表【注意：最多返回10个】
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
