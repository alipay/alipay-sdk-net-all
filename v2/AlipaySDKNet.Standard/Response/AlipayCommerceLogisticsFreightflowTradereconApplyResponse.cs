using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTradereconApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowTradereconApplyResponse : AopResponse
    {
        /// <summary>
        /// 对账文件下载链接(五分钟有效期)
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 账单日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("result_date")]
        public string ResultDate { get; set; }
    }
}
