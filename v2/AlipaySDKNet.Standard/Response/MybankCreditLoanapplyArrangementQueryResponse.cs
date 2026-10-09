using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyArrangementQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyArrangementQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询指定客户、产品下客户签订的合约状态等信息
        /// </summary>
        [XmlArray("arrangement_query_result")]
        [XmlArrayItem("arrangement_open_query_result_v_o")]
        public List<ArrangementOpenQueryResultVO> ArrangementQueryResult { get; set; }
    }
}
