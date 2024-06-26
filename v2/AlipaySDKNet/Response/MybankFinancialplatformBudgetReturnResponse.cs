using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankFinancialplatformBudgetReturnResponse.
    /// </summary>
    public class MybankFinancialplatformBudgetReturnResponse : AopResponse
    {
        /// <summary>
        /// 退回成功后的记录id
        /// </summary>
        [XmlElement("result_data")]
        public BkdfmacBizActionLogDTO ResultData { get; set; }

        /// <summary>
        /// 错误的详细信息，用于具体描述错误信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
