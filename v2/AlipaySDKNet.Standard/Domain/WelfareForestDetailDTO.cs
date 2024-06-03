using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareForestDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareForestDetailDTO : AopObject
    {
        /// <summary>
        /// 公益林奖励详情信息
        /// </summary>
        [XmlArray("reward_info_list")]
        [XmlArrayItem("reward_d_t_o")]
        public List<RewardDTO> RewardInfoList { get; set; }

        /// <summary>
        /// 用户在该公益林下已经获得的奖励信息，本列表仅存储奖励编码，奖励详情请看reward_infos
        /// </summary>
        [XmlArray("rewarded_code_list")]
        [XmlArrayItem("string")]
        public List<string> RewardedCodeList { get; set; }

        /// <summary>
        /// 公益林实体信息，包含该公益林所有配置相关内容
        /// </summary>
        [XmlElement("welfare_forest_entity")]
        public WelfareForestEntityDTO WelfareForestEntity { get; set; }

        /// <summary>
        /// 公益林个人浇水信息
        /// </summary>
        [XmlElement("welfare_forest_person_water_info")]
        public WelfareForestPersonWaterDTO WelfareForestPersonWaterInfo { get; set; }

        /// <summary>
        /// 公益林浇水统计数据，查询该林子相关的统计信息
        /// </summary>
        [XmlElement("welfare_forest_water_summary_info")]
        public WelfareForestWaterSummaryDTO WelfareForestWaterSummaryInfo { get; set; }
    }
}
