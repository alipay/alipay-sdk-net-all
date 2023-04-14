using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetIssueSubmitModel : AopObject
    {
        /// <summary>
        /// 资产预申请成功后返回的内部资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 针对sign_data签名的对应公钥
        /// </summary>
        [XmlElement("pub_key")]
        public string PubKey { get; set; }

        /// <summary>
        /// 针对sign_data签名的签名算法，目前支持SHA256WithRSA/SHA1WithRSA/SM3WithSM2
        /// </summary>
        [XmlElement("sign_algorithm")]
        public string SignAlgorithm { get; set; }

        /// <summary>
        /// 资产预申请成功后返回的待签名数据，对原始utf-8编码的xml签名数据，做base64编码
        /// </summary>
        [XmlElement("sign_data")]
        public string SignData { get; set; }

        /// <summary>
        /// 针对sign_data的签名，Base64格式编码
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
