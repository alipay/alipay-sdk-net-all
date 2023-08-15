using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayrightrealQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayrightrealQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市分布
        /// </summary>
        [XmlElement("online_torch_replay_city_distribute")]
        public string OnlineTorchReplayCityDistribute { get; set; }

        /// <summary>
        /// 今日火炬传递总人次
        /// </summary>
        [XmlElement("online_torch_replay_today_cnt")]
        public long OnlineTorchReplayTodayCnt { get; set; }

        /// <summary>
        /// 今日火炬传递总人数
        /// </summary>
        [XmlElement("online_torch_replay_today_user_cnt")]
        public long OnlineTorchReplayTodayUserCnt { get; set; }

        /// <summary>
        /// 线上火炬传递总人次
        /// </summary>
        [XmlElement("online_torch_replay_total_cnt")]
        public long OnlineTorchReplayTotalCnt { get; set; }

        /// <summary>
        /// 线上火炬传递总人数
        /// </summary>
        [XmlElement("online_torch_replay_total_user_cnt")]
        public long OnlineTorchReplayTotalUserCnt { get; set; }
    }
}
