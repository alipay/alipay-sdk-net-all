using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowFundtradereconApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowFundtradereconApplyResponse : AopResponse
    {
        /// <summary>
        /// 同入参
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 对账文件下载链接(五分钟有效期)
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 同入参
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }
    }
}
