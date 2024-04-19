using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetIssueApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请成功后生成的内部资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 提交申请时传入的资产id
        /// </summary>
        [XmlElement("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 申请成功后返回，待签名上链的业务信息，base64解码后为utf8编码的原始签名信息，xml格式
        /// </summary>
        [XmlElement("sign_data")]
        public string SignData { get; set; }
    }
}
