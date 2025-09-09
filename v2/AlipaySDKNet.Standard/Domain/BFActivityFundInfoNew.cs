using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BFActivityFundInfoNew Data Structure.
    /// </summary>
    [Serializable]
    public class BFActivityFundInfoNew : AopObject
    {
        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 多主体信息
        /// </summary>
        [XmlArray("fund_info_list")]
        [XmlArrayItem("b_f_activity_fund_info")]
        public List<BFActivityFundInfo> FundInfoList { get; set; }

        /// <summary>
        /// 机构ID，没有机构ID时与资产类型保持一致
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
