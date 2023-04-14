using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetBbaremainamountQueryResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetBbaremainamountQueryResponse : AopResponse
    {
        /// <summary>
        /// BBA可用、剩余金额
        /// </summary>
        [XmlElement("result_data")]
        public BizBudgetApplyAmountDTO ResultData { get; set; }

        /// <summary>
        /// 错误的详细信息，用于具体描述错误信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
