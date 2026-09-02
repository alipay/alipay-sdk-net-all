using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppFeatureQueryResponse.
    /// </summary>
    public class AlipayEbppEbppFeatureQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次号即文件名
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 总笔数
        /// </summary>
        [XmlElement("cnt")]
        public string Cnt { get; set; }

        /// <summary>
        /// 异常特征值动态输出
        /// </summary>
        [XmlElement("feature_ext")]
        public string FeatureExt { get; set; }

        /// <summary>
        /// 字符串时间
        /// </summary>
        [XmlElement("session_end")]
        public string SessionEnd { get; set; }

        /// <summary>
        /// 字符串日期
        /// </summary>
        [XmlElement("session_start")]
        public string SessionStart { get; set; }

        /// <summary>
        /// 单位为分
        /// </summary>
        [XmlElement("sum_amt")]
        public string SumAmt { get; set; }
    }
}
