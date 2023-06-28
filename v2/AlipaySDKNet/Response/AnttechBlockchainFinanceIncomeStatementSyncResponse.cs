using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeStatementSyncResponse.
    /// </summary>
    public class AnttechBlockchainFinanceIncomeStatementSyncResponse : AopResponse
    {
        /// <summary>
        /// 结算单同步流水号，同步成功后返回
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
