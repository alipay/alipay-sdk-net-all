using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntsportsCurrentpathQueryResponse.
    /// </summary>
    public class AlipaySocialAntsportsCurrentpathQueryResponse : AopResponse
    {
        /// <summary>
        /// 运动数据今日已消费步数
        /// </summary>
        [XmlElement("exercise_consume_step_count")]
        public long ExerciseConsumeStepCount { get; set; }

        /// <summary>
        /// 运动数据今日行走步数
        /// </summary>
        [XmlElement("exercise_produce_step_count")]
        public long ExerciseProduceStepCount { get; set; }

        /// <summary>
        /// 用户路线参当前路线已走步数
        /// </summary>
        [XmlElement("forward_step_count")]
        public long ForwardStepCount { get; set; }

        /// <summary>
        /// 最小起go步数
        /// </summary>
        [XmlElement("min_go_steps")]
        public long MinGoSteps { get; set; }

        /// <summary>
        /// 下一个路线ID
        /// </summary>
        [XmlElement("next_unlock_path_id")]
        public string NextUnlockPathId { get; set; }

        /// <summary>
        /// 路线完成状态
        /// </summary>
        [XmlElement("path_complete_status")]
        public string PathCompleteStatus { get; set; }

        /// <summary>
        /// 路线ID
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 路线加入状态
        /// </summary>
        [XmlElement("path_join_status")]
        public string PathJoinStatus { get; set; }

        /// <summary>
        /// 路线名称
        /// </summary>
        [XmlElement("path_name")]
        public string PathName { get; set; }

        /// <summary>
        /// 加入路线的流水
        /// </summary>
        [XmlElement("path_record_id")]
        public string PathRecordId { get; set; }

        /// <summary>
        /// 当前行走的路线场景
        /// </summary>
        [XmlElement("path_scene")]
        public string PathScene { get; set; }

        /// <summary>
        /// 路线归属站点编码
        /// </summary>
        [XmlElement("path_station_code")]
        public string PathStationCode { get; set; }

        /// <summary>
        /// 路线归属站点名称
        /// </summary>
        [XmlElement("path_station_name")]
        public string PathStationName { get; set; }
    }
}
