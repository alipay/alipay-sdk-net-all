using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayrightstatQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayrightstatQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日线下火炬传递城市数
        /// </summary>
        [XmlElement("offline_torch_replay_city_today_cnt")]
        public long OfflineTorchReplayCityTodayCnt { get; set; }

        /// <summary>
        /// 线下火炬传递城市总数
        /// </summary>
        [XmlElement("offline_torch_replay_city_total_cnt")]
        public long OfflineTorchReplayCityTotalCnt { get; set; }

        /// <summary>
        /// 今日线下火炬传递人数
        /// </summary>
        [XmlElement("offline_torch_replay_today_cnt")]
        public long OfflineTorchReplayTodayCnt { get; set; }

        /// <summary>
        /// 线下火炬传递总人数
        /// </summary>
        [XmlElement("offline_torch_replay_total_cnt")]
        public long OfflineTorchReplayTotalCnt { get; set; }

        /// <summary>
        /// 线下传递人群画像
        /// </summary>
        [XmlElement("offline_torchbearer_portrait")]
        public string OfflineTorchbearerPortrait { get; set; }

        /// <summary>
        /// 今日线下传递手榜单
        /// </summary>
        [XmlElement("offline_torchbearer_today_list")]
        public string OfflineTorchbearerTodayList { get; set; }
    }
}
