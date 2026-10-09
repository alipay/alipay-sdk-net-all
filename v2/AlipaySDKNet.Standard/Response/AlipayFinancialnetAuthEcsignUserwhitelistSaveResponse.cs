using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignUserwhitelistSaveResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignUserwhitelistSaveResponse : AopResponse
    {
        /// <summary>
        /// 电子签约订单号,唯一值。
        /// </summary>
        [XmlElement("sign_order_no")]
        public string SignOrderNo { get; set; }
    }
}
