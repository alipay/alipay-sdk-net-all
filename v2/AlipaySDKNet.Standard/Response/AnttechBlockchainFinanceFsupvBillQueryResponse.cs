using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvBillQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 对账单下载地址，请在有效时间内完成下载。 默认有效时间10分钟
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
