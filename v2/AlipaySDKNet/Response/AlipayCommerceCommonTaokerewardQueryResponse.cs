using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaokerewardQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTaokerewardQueryResponse : AopResponse
    {
        /// <summary>
        /// 激励记录信息
        /// </summary>
        [XmlArray("reward_record_list")]
        [XmlArrayItem("tao_ke_reward_record_d_t_o")]
        public List<TaoKeRewardRecordDTO> RewardRecordList { get; set; }
    }
}
