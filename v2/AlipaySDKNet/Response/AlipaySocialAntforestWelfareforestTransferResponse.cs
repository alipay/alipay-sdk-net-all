using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestWelfareforestTransferResponse.
    /// </summary>
    public class AlipaySocialAntforestWelfareforestTransferResponse : AopResponse
    {
        /// <summary>
        /// 本次实际浇水能量g数
        /// </summary>
        [XmlElement("effect_energy")]
        public long EffectEnergy { get; set; }

        /// <summary>
        /// 如果入参bizNo发生幂等，则森林侧不会进行写入操作，本字段会被标记为true，同时返回用户当前公益林已经获得的所有奖励
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 用户在本次浇水操作新获得的奖励id列表（如果幂等，这个为空）
        /// </summary>
        [XmlArray("reward_code_list_after_water")]
        [XmlArrayItem("string")]
        public List<string> RewardCodeListAfterWater { get; set; }

        /// <summary>
        /// 公益林所有的奖励信息（幂等也会正常返回数据）
        /// </summary>
        [XmlArray("reward_info_list")]
        [XmlArrayItem("reward_d_t_o")]
        public List<RewardDTO> RewardInfoList { get; set; }

        /// <summary>
        /// 已经获得的奖励列表（如果幂等，如果有数据的话这个也会返回数据）
        /// </summary>
        [XmlArray("rewarded_code_list")]
        [XmlArrayItem("string")]
        public List<string> RewardedCodeList { get; set; }
    }
}
