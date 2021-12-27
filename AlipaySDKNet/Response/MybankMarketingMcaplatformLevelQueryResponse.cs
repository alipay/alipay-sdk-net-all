using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingMcaplatformLevelQueryResponse.
    /// </summary>
    public class MybankMarketingMcaplatformLevelQueryResponse : AopResponse
    {
        /// <summary>
        /// 绿色等级，不唯一 枚举值L1,L2,L3,L4,L5
        /// </summary>
        [XmlElement("green_level")]
        public string GreenLevel { get; set; }

        /// <summary>
        /// 绿色等级成长值，0～100
        /// </summary>
        [XmlElement("growth_value")]
        public long GrowthValue { get; set; }
    }
}
