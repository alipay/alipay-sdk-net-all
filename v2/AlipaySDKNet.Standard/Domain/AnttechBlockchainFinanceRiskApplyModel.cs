using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceRiskApplyModel : AopObject
    {
        /// <summary>
        /// 因何种资产业务发起的贷前风控申请
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 请求的唯一性标识，用于幂等处理。 若不传，则使用风控参数作为幂等条件
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// JSON字符串，字段参见资产字段信息表，风控字段。
        /// </summary>
        [XmlElement("risk_object")]
        public string RiskObject { get; set; }

        /// <summary>
        /// 风控类型，默认贷前风控
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }
    }
}
