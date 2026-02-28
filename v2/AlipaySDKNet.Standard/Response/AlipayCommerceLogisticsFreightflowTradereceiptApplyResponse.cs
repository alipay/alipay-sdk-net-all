using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTradereceiptApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowTradereceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// Base64加密 5分钟有效期，过期需换单重新申请。
        /// </summary>
        [XmlElement("pdf_download_url")]
        public string PdfDownloadUrl { get; set; }

        /// <summary>
        /// 电子回单下载的文件是否已生成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
