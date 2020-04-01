using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetRegisterSubmitModel : AopObject
    {
        /// <summary>
        /// 资产发现中心内部资产编号，通过apply返回
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，同apply，为直观，submit也必传。
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产发行申请后，后续操作提交。
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 提交的数据，根据operate不同而不同
        /// </summary>
        [XmlElement("submit_data")]
        public string SubmitData { get; set; }
    }
}
