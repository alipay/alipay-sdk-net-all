using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeAssetSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceIncomeAssetSubmitResponse : AopResponse
    {
        /// <summary>
        /// 资产ID，资产登记成功后返回，在后续接口中标识资产身份
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 登记流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
