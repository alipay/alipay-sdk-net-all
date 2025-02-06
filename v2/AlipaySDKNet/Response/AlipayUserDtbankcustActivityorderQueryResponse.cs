using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustActivityorderQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustActivityorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 数字分行活动唯一id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水单据唯一id
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 外部唯一业务幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发放流水状态，SUCCESS表示发放成功，FAILED表示发放失败，INIT表示发放处理中，可原单重试发放，勿换单重试，以免导致额外损失
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
