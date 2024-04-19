using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentGroupsuborderAddResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentGroupsuborderAddResponse : AopResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 主单号
        /// </summary>
        [XmlElement("summary_order_no")]
        public string SummaryOrderNo { get; set; }
    }
}
