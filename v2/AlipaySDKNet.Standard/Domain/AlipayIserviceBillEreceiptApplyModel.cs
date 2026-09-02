using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceBillEreceiptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceBillEreceiptApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝资金流水号。发薪转账成功后返回的唯一标识，可通过星云薪酬发薪结果获取。
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }
    }
}
