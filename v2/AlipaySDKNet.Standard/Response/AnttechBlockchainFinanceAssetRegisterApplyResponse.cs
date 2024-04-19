using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterApplyResponse : AopResponse
    {
        /// <summary>
        /// 资产登记申请结果，不同资产类型不同，比如可能包含代签名原始数据等。
        /// </summary>
        [XmlElement("apply_result")]
        public string ApplyResult { get; set; }

        /// <summary>
        /// 登记成功后，返回资产登记中心内部资产编号
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 申请时提交的外部资产编号
        /// </summary>
        [XmlElement("out_asset_id")]
        public string OutAssetId { get; set; }
    }
}
