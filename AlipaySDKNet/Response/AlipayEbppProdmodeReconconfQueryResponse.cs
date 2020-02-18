using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppProdmodeReconconfQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeReconconfQueryResponse : AopResponse
    {
        /// <summary>
        /// 对账基准（以支付宝为准/以机构为准）
        /// </summary>
        [XmlElement("check_depend")]
        public string CheckDepend { get; set; }

        /// <summary>
        /// 对账粒度（以主机构为粒度对账/以子机构为粒度对账）
        /// </summary>
        [XmlElement("check_grade")]
        public string CheckGrade { get; set; }

        /// <summary>
        /// 清算粒度（以主机构为粒度清算/以子机构为粒度清算）
        /// </summary>
        [XmlElement("clear_grade")]
        public string ClearGrade { get; set; }

        /// <summary>
        /// 日切时间:小时
        /// </summary>
        [XmlElement("cut_hour")]
        public string CutHour { get; set; }

        /// <summary>
        /// 日切时间:分钟
        /// </summary>
        [XmlElement("cut_min")]
        public string CutMin { get; set; }

        /// <summary>
        /// 日切时间:秒
        /// </summary>
        [XmlElement("cut_sec")]
        public string CutSec { get; set; }

        /// <summary>
        /// 是否有对账配置内容
        /// </summary>
        [XmlElement("has_recon_conf")]
        public string HasReconConf { get; set; }

        /// <summary>
        /// 无对账内容配置原因
        /// </summary>
        [XmlElement("no_conf_reason")]
        public string NoConfReason { get; set; }

        /// <summary>
        /// 生成文件时间（以支付时间为准/以销账时间为准）
        /// </summary>
        [XmlElement("recon_time")]
        public string ReconTime { get; set; }

        /// <summary>
        /// T+N退款规则（以机构为准）
        /// </summary>
        [XmlElement("refund_rule")]
        public string RefundRule { get; set; }
    }
}
