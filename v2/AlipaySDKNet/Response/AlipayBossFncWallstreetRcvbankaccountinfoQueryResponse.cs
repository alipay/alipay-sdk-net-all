using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncWallstreetRcvbankaccountinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncWallstreetRcvbankaccountinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户信息列表
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("bank_account_info_dto")]
        public List<BankAccountInfoDto> ResultSet { get; set; }
    }
}
