using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntPcinstpromoPcinstpromoActivityorderQueryResponse.
    /// </summary>
    public class AntPcinstpromoPcinstpromoActivityorderQueryResponse : AopResponse
    {
        /// <summary>
        /// P站配置的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水单据唯一id
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 流水状态 INIT("INIT", "初始化"), SUCCESS("SUCCESS", "成功"), FAILED("FAILED", "失败"), PENDING("PENDING", "挂起"),
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
