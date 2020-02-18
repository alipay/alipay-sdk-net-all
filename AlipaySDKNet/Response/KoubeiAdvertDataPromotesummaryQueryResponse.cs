using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryQueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑平台推广数据
        /// </summary>
        [XmlElement("kb_platform_promote_data")]
        public PromoteDataModel KbPlatformPromoteData { get; set; }

        /// <summary>
        /// 其他推广者推广数据
        /// </summary>
        [XmlElement("others_promote_data")]
        public PromoteDataModel OthersPromoteData { get; set; }

        /// <summary>
        /// 入参时间段内总推广数据
        /// </summary>
        [XmlElement("part_promote_data")]
        public PromoteDataModel PartPromoteData { get; set; }

        /// <summary>
        /// 自己推广数据
        /// </summary>
        [XmlElement("self_promote_data")]
        public PromoteDataModel SelfPromoteData { get; set; }

        /// <summary>
        /// 总推广数据
        /// </summary>
        [XmlElement("total_promote_data")]
        public PromoteDataModel TotalPromoteData { get; set; }
    }
}
