using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeFundtransferQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeFundtransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金划拨单的理论划拨金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 学费码的资金划拨单号。是学费码打款单、退款单的业务单号
        /// </summary>
        [XmlElement("fund_transfer_no")]
        public string FundTransferNo { get; set; }

        /// <summary>
        /// 资金划拨的外部请求编号，对应服务商申请打款或申请退款请求的request_id
        /// </summary>
        [XmlElement("out_req_no")]
        public string OutReqNo { get; set; }

        /// <summary>
        /// 资金划拨单关联任务
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("edu_plan_instance_info")]
        public List<EduPlanInstanceInfo> PlanList { get; set; }

        /// <summary>
        /// 学费码的资金划拨状态：0-待划拨；1-划拨中；3-划拨成功
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
