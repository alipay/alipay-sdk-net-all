using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniPlanOperateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 支付后推荐方案详情列表
        /// </summary>
        [XmlArray("page_data")]
        [XmlArrayItem("payment_success_page_plan_info")]
        public List<PaymentSuccessPagePlanInfo> PageData { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付后推荐方案记录总数
        /// </summary>
        [XmlElement("total_number")]
        public long TotalNumber { get; set; }
    }
}
