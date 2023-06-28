using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskdataQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务的激励信息
        /// </summary>
        [XmlArray("reward_info")]
        [XmlArrayItem("task_instance_reward_info_d_t_o")]
        public List<TaskInstanceRewardInfoDTO> RewardInfo { get; set; }

        /// <summary>
        /// 任务扫码量
        /// </summary>
        [XmlElement("scan_num")]
        public string ScanNum { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_templete_id")]
        public string TaskTempleteId { get; set; }

        /// <summary>
        /// 任务交易下单量
        /// </summary>
        [XmlElement("trade_num")]
        public string TradeNum { get; set; }
    }
}
