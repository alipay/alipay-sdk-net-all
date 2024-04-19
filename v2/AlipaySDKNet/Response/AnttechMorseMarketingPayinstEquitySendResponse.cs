using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingPayinstEquitySendResponse.
    /// </summary>
    public class AnttechMorseMarketingPayinstEquitySendResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁侧返回的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 权益发放结果详情
        /// </summary>
        [XmlArray("result_details")]
        [XmlArrayItem("pay_inst_equity_send_result")]
        public List<PayInstEquitySendResult> ResultDetails { get; set; }

        /// <summary>
        /// 发放成功后生成的发放凭证号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 全部成功返回true，有任何失败返回false
        /// </summary>
        [XmlElement("send_success")]
        public bool SendSuccess { get; set; }
    }
}
