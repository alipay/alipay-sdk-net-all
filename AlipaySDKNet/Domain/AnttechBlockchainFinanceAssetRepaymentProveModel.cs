using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRepaymentProveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetRepaymentProveModel : AopObject
    {
        /// <summary>
        /// 资产包ID
        /// </summary>
        [XmlElement("asset_package_id")]
        public string AssetPackageId { get; set; }

        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 报文编码算法
        /// </summary>
        [XmlElement("encode_type")]
        public string EncodeType { get; set; }

        /// <summary>
        /// 证明相关原始加密/压缩请求报文
        /// </summary>
        [XmlElement("prove_encoded_req")]
        public string ProveEncodedReq { get; set; }

        /// <summary>
        /// 证明相关原始加密/压缩应答报文
        /// </summary>
        [XmlElement("prove_encoded_res")]
        public string ProveEncodedRes { get; set; }

        /// <summary>
        /// 还款操作类型
        /// </summary>
        [XmlElement("repay_action")]
        public string RepayAction { get; set; }

        /// <summary>
        /// 请求序列号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
