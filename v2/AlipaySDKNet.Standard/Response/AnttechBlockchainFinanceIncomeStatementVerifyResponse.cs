using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeStatementVerifyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceIncomeStatementVerifyResponse : AopResponse
    {
        /// <summary>
        /// 核销流水号，核销成功后返回
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
