using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibCreateResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibCreateResponse : AopResponse
    {
        /// <summary>
        /// 预算库余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 预算库编码
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 消息原因，当借口异常时返回异常原因，如幂等异常时，返回原业务号对应的预算库编码
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
