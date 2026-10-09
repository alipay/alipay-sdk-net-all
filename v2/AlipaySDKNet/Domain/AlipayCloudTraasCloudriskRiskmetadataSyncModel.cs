using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasCloudriskRiskmetadataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasCloudriskRiskmetadataSyncModel : AopObject
    {
        /// <summary>
        /// 风险元数据参数，包含元数据信息及操作类型
        /// </summary>
        [XmlArray("risk_meta_data_list")]
        [XmlArrayItem("risk_meta_data")]
        public List<RiskMetaData> RiskMetaDataList { get; set; }
    }
}
