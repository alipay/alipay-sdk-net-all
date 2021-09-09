using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRepaymentProveResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRepaymentProveResponse : AopResponse
    {
        /// <summary>
        /// 是否受理
        /// </summary>
        [XmlElement("accepted")]
        public bool Accepted { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
