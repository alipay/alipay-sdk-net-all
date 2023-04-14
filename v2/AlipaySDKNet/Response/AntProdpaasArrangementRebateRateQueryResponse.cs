using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasArrangementRebateRateQueryResponse.
    /// </summary>
    public class AntProdpaasArrangementRebateRateQueryResponse : AopResponse
    {
        /// <summary>
        /// 一级类目ID
        /// </summary>
        [XmlElement("category_1_id")]
        public string Category1Id { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [XmlElement("category_1_name")]
        public string Category1Name { get; set; }

        /// <summary>
        /// 结束时间，精确到天
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 开始时间，精确到天
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 费率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }
    }
}
