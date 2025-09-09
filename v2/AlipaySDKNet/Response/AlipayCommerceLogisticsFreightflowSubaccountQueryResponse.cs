using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowSubaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额，单位分
        /// </summary>
        [XmlElement("account_balance")]
        public string AccountBalance { get; set; }
    }
}
