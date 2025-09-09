using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountLoanaccountQueryResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountLoanaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 流水列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("loan_account_query_detail_d_t_o")]
        public List<LoanAccountQueryDetailDTO> DataList { get; set; }

        /// <summary>
        /// 下次检索传递时间;'2025-08-13 10:00:00'的格式为'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("next_end_time")]
        public string NextEndTime { get; set; }

        /// <summary>
        /// 分页时若有下一页，则会有nextOrderNo，放入下一次请求中
        /// </summary>
        [XmlElement("next_order_no")]
        public string NextOrderNo { get; set; }
    }
}
