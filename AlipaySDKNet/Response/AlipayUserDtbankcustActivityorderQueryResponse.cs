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
        /// 流水状态 INIT("INIT", "初始化"),  SUCCESS("SUCCESS", "成功"), FAILED("FAILED", "失败"), PENDING("PENDING", "挂起"),
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
