using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowParentaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowParentaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额，单位分
        /// </summary>
        [XmlElement("account_balance")]
        public string AccountBalance { get; set; }
    }
}
