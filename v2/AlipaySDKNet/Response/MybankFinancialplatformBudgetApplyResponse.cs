using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankFinancialplatformBudgetApplyResponse.
    /// </summary>
    public class MybankFinancialplatformBudgetApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请成功后的记录列表
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("bkdfmac_biz_action_log_d_t_o")]
        public List<BkdfmacBizActionLogDTO> ResultData { get; set; }

        /// <summary>
        /// 错误具体信息描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
