using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonAccountWithdrawResponse.
    /// </summary>
    public class AlipayCommerceCommonAccountWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 提现成功金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
