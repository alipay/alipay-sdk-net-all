using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayGroupAddResponse.
    /// </summary>
    public class AlipayFundEnterprisepayGroupAddResponse : AopResponse
    {
        /// <summary>
        /// 因公付账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 资金群组号
        /// </summary>
        [XmlElement("fund_group_id")]
        public string FundGroupId { get; set; }

        /// <summary>
        /// 外部群组号，业务号
        /// </summary>
        [XmlElement("out_group_id")]
        public string OutGroupId { get; set; }
    }
}
