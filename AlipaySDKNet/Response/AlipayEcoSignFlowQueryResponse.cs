using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoSignFlowQueryResponse.
    /// </summary>
    public class AlipayEcoSignFlowQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件主题
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 文件有效截止日期
        /// </summary>
        [XmlElement("contract_validity")]
        public long ContractValidity { get; set; }

        /// <summary>
        /// 流程描述, 如果流程已拒签或已撤回, 并且存在拒签或撤回原因, 流程描述显示为原因, 否则默认为流程状态描述
        /// </summary>
        [XmlElement("flow_desc")]
        public string FlowDesc { get; set; }

        /// <summary>
        /// 流程结束时间
        /// </summary>
        [XmlElement("flow_end_time")]
        public long FlowEndTime { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 流程开始时间
        /// </summary>
        [XmlElement("flow_start_time")]
        public long FlowStartTime { get; set; }

        /// <summary>
        /// 流程状态,0-草稿 1-签署中 2-完成 3-撤销 4-终止 5-过期 6-删除 7-拒签
        /// </summary>
        [XmlElement("flow_status")]
        public long FlowStatus { get; set; }

        /// <summary>
        /// 通知开发者地址
        /// </summary>
        [XmlElement("notice_developer_url")]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 签署有效截止日期
        /// </summary>
        [XmlElement("sign_validity")]
        public long SignValidity { get; set; }
    }
}
