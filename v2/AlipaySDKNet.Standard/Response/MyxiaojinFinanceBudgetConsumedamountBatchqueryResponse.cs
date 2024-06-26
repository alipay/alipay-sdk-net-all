using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MyxiaojinFinanceBudgetConsumedamountBatchqueryResponse.
    /// </summary>
    public class MyxiaojinFinanceBudgetConsumedamountBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 根据BizUkIds查询出的占用情况
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("cfbudmac_biz_action_consumed_amounts_d_t_o")]
        public List<CfbudmacBizActionConsumedAmountsDTO> ResultData { get; set; }

        /// <summary>
        /// 错误具体信息描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
