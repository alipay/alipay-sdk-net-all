using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIsvImportedbillQueryResponse.
    /// </summary>
    public class AlipayEbppIsvImportedbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 解析失败数量
        /// </summary>
        [XmlElement("analysis_fail_count")]
        public long AnalysisFailCount { get; set; }

        /// <summary>
        /// 解析成功数量
        /// </summary>
        [XmlElement("analysis_suc_count")]
        public long AnalysisSucCount { get; set; }

        /// <summary>
        /// 写入失败数量
        /// </summary>
        [XmlElement("import_fail_count")]
        public long ImportFailCount { get; set; }

        /// <summary>
        /// 写入成功数量
        /// </summary>
        [XmlElement("import_suc_count")]
        public long ImportSucCount { get; set; }

        /// <summary>
        /// 导入账单总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
