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
        /// 检测是否完成。true-是，false-否
        /// </summary>
        [XmlElement("audit_done")]
        public bool AuditDone { get; set; }

        /// <summary>
        /// 检测是否通过。true-通过，false-不通过
        /// </summary>
        [XmlElement("audit_pass")]
        public bool AuditPass { get; set; }

        /// <summary>
        /// 当audit_pass=false时，表示错误细节
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 外部业务标识。和入参一致。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
