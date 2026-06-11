using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalArchiveEcgSaveResponse.
    /// </summary>
    public class AlipayCommerceMedicalArchiveEcgSaveResponse : AopResponse
    {
        /// <summary>
        /// 保存失败的报告数量
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 保存成功的报告数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
