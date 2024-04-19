using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthBalanceQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户余额数值
        /// </summary>
        [XmlElement("account_balance")]
        public string AccountBalance { get; set; }

        /// <summary>
        /// 返回余额币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 响应结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 响应结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 业务结果是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
