using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustAccountQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到用户支付宝账号信息列表
        /// </summary>
        [XmlArray("account_no_info_list")]
        [XmlArrayItem("account_no_info")]
        public List<AccountNoInfo> AccountNoInfoList { get; set; }
    }
}
