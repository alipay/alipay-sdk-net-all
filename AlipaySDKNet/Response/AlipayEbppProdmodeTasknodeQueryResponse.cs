using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeTasknodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前任务最新更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 是否可以编辑所有
        /// </summary>
        [XmlElement("is_edit_all")]
        public string IsEditAll { get; set; }

        /// <summary>
        /// 编辑结算部分
        /// </summary>
        [XmlElement("is_edit_fund")]
        public string IsEditFund { get; set; }

        /// <summary>
        /// 审批节点编码
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 任务状态描述
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        [XmlElement("reject")]
        public string Reject { get; set; }

        /// <summary>
        /// 拒绝时间
        /// </summary>
        [XmlElement("reject_time")]
        public string RejectTime { get; set; }
    }
}
