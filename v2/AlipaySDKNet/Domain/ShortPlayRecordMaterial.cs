using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayRecordMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayRecordMaterial : AopObject
    {
        /// <summary>
        /// 演员列表。
        /// </summary>
        [XmlArray("actor_list")]
        [XmlArrayItem("short_play_actor")]
        public List<ShortPlayActor> ActorList { get; set; }

        /// <summary>
        /// 全部演员片酬占制作总成本比例（取值范围 0~1）
        /// </summary>
        [XmlElement("actor_salary_ratio")]
        public string ActorSalaryRatio { get; set; }

        /// <summary>
        /// 动画类短剧类型，可选值：动画漫剧 / 沙雕漫剧 / 动态解说漫剧 / 静态解说漫剧（节目分类为 动画微短剧 时必填，单选）
        /// </summary>
        [XmlElement("animation_type")]
        public string AnimationType { get; set; }

        /// <summary>
        /// 受众定位，可选值：男频 / 女频（多选）
        /// </summary>
        [XmlArray("audience")]
        [XmlArrayItem("string")]
        public List<string> Audience { get; set; }

        /// <summary>
        /// 平均每集时长（分钟）
        /// </summary>
        [XmlElement("avg_duration")]
        public long AvgDuration { get; set; }

        /// <summary>
        /// 特殊声明。无：0；该剧内容由 AI 生成：1；该剧有未成年出演：2
        /// </summary>
        [XmlElement("content_declared")]
        public string ContentDeclared { get; set; }

        /// <summary>
        /// 版权方名称，最多30个字
        /// </summary>
        [XmlElement("copyright_holder")]
        public string CopyrightHolder { get; set; }

        /// <summary>
        /// 导演列表。
        /// </summary>
        [XmlArray("director")]
        [XmlArrayItem("string")]
        public List<string> Director { get; set; }

        /// <summary>
        /// 是否全网首轮播出。0 或不传：否；1：是
        /// </summary>
        [XmlElement("first_broadcast")]
        public bool FirstBroadcast { get; set; }

        /// <summary>
        /// 主要演员片酬占总片酬比例（取值范围 0~1）
        /// </summary>
        [XmlElement("main_actor_salary_ratio")]
        public string MainActorSalaryRatio { get; set; }

        /// <summary>
        /// 制作费用（元）
        /// </summary>
        [XmlElement("playlet_production_cost")]
        public long PlayletProductionCost { get; set; }

        /// <summary>
        /// 制片方。
        /// </summary>
        [XmlElement("producer")]
        public string Producer { get; set; }

        /// <summary>
        /// 节目分类，可选值：真人微短剧 / AI真人微短剧 / 动画微短剧（单选）
        /// </summary>
        [XmlElement("program_category")]
        public string ProgramCategory { get; set; }

        /// <summary>
        /// 编剧列表
        /// </summary>
        [XmlArray("screen_writer")]
        [XmlArrayItem("string")]
        public List<string> ScreenWriter { get; set; }

        /// <summary>
        /// 总集数
        /// </summary>
        [XmlElement("seqs_count")]
        public long SeqsCount { get; set; }

        /// <summary>
        /// 短剧简介，最少 200 个字
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }
    }
}
