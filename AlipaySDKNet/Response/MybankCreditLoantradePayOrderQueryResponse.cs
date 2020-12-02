using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayOrderQueryResponse.
    /// </summary>
    public class MybankCreditLoantradePayOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 系统异常
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        [XmlArray("query_result")]
        [XmlArrayItem("credit_pay_order_query_v_o")]
        public List<CreditPayOrderQueryVO> QueryResult { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
