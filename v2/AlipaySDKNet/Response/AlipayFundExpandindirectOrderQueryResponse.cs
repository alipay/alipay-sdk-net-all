using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundExpandindirectOrderQueryResponse.
    /// </summary>
    public class AlipayFundExpandindirectOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 进件单创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 进件单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 进件单审核不通过原因
        /// </summary>
        [XmlElement("risk_review_remark")]
        public string RiskReviewRemark { get; set; }

        /// <summary>
        /// 二级商户名称
        /// </summary>
        [XmlElement("secondary_partner_name")]
        public string SecondaryPartnerName { get; set; }

        /// <summary>
        /// 进件单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 进件单任务完结时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("task_finish_time")]
        public string TaskFinishTime { get; set; }
    }
}
