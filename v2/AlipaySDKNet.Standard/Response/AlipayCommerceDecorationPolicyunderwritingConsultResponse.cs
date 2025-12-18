using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationPolicyunderwritingConsultResponse.
    /// </summary>
    public class AlipayCommerceDecorationPolicyunderwritingConsultResponse : AopResponse
    {
        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 订单号，处理成功时必传
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号。不可重复,幂等字段
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 保障截止日期 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("policy_end_date")]
        public string PolicyEndDate { get; set; }

        /// <summary>
        /// 保障生效日期 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("policy_start_date")]
        public string PolicyStartDate { get; set; }

        /// <summary>
        /// 保单状态 PENDING-核保受理  UNDERWRITING_SUCCESS-核保成功 UNDERWRITING_FAILURE-核保失败 POLICY_ISSUED_SUCCESS-承保成功 POLICY_ISSUED_FAILURE-承保失败
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 应付保费，单位为分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保险计划code 家财: JiaCai 团意1:TuanYi1 团意2:TuanYi2
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 项目编号或合同编号
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 子订单列表
        /// </summary>
        [XmlArray("sub_order_no_list")]
        [XmlArrayItem("sub_order_v_o")]
        public List<SubOrderVO> SubOrderNoList { get; set; }

        /// <summary>
        /// 总保费，单位:分
        /// </summary>
        [XmlElement("total_premium")]
        public long TotalPremium { get; set; }
    }
}
