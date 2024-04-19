using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncApbillBillcustviewBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncApbillBillcustviewBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 应付月账单客户视图
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ap_monthly_bill_cust_open_api_response")]
        public List<ApMonthlyBillCustOpenApiResponse> ResultSet { get; set; }
    }
}
