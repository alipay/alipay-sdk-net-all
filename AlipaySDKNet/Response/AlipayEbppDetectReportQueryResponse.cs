using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppDetectReportQueryResponse.
    /// </summary>
    public class AlipayEbppDetectReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [XmlElement("audit_done")]
        public bool AuditDone { get; set; }

        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [XmlElement("audit_pass")]
        public bool AuditPass { get; set; }

        /// <summary>
        /// 检测结果详情。JSON数组字符串。列出每个检测项的检测详情。
        /// </summary>
        [XmlElement("detect_detail")]
        public string DetectDetail { get; set; }

        /// <summary>
        /// 检测状态.  * 0-未查到报告(检测未开始或检测异常)  * 1-检测中  * 2-检测结束并生成检测报告
        /// </summary>
        [XmlElement("detect_status")]
        public long DetectStatus { get; set; }

        /// <summary>
        /// 注意：该字段废弃
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 注意：该字段废弃。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 整体检测是否通过. 只有当detectStatus=2时才会有值.  * true-检测通过  * false-检测不通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 检测结果一句话描述
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }
    }
}
