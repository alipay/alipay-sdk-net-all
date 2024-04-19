using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherBatchsendResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherBatchsendResponse : AopResponse
    {
        /// <summary>
        /// 发券结果列表
        /// </summary>
        [XmlArray("activity_send_voucher_result_info_list")]
        [XmlArrayItem("activity_send_voucher_result_info")]
        public List<ActivitySendVoucherResultInfo> ActivitySendVoucherResultInfoList { get; set; }
    }
}
