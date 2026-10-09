using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MyxiaojinFinanceBudgetBbaremainamountQueryResponse.
    /// </summary>
    public class MyxiaojinFinanceBudgetBbaremainamountQueryResponse : AopResponse
    {
        /// <summary>
        /// BBA可用、剩余金额
        /// </summary>
        [XmlElement("result_data")]
        public CfbudmacBizBudgetApplyAmountDTO ResultData { get; set; }

        /// <summary>
        /// 错误的详细信息，用于具体描述错误信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
