using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountQueryQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountQueryQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构专户信息列表
        /// </summary>
        [XmlArray("account_info")]
        [XmlArrayItem("sp_account_info_vo")]
        public List<SpAccountInfoVo> AccountInfo { get; set; }
    }
}
