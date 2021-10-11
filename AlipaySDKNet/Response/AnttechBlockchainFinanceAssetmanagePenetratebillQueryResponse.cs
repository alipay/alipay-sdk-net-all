using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetmanagePenetratebillQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetmanagePenetratebillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
