using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayGroupQueryResponse.
    /// </summary>
    public class AlipayFundEnterprisepayGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 内部群组号
        /// </summary>
        [XmlElement("fund_group_id")]
        public string FundGroupId { get; set; }

        /// <summary>
        /// 该群所对应的出资主体账号
        /// </summary>
        [XmlElement("fund_identity")]
        public string FundIdentity { get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部群组号
        /// </summary>
        [XmlElement("out_group_id")]
        public string OutGroupId { get; set; }
    }
}
