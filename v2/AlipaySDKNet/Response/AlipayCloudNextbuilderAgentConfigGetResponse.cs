using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentConfigGetResponse.
    /// </summary>
    public class AlipayCloudNextbuilderAgentConfigGetResponse : AopResponse
    {
        /// <summary>
        /// 配置版本号
        /// </summary>
        [XmlElement("config_version")]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// 是否生成相关问题建议
        /// </summary>
        [XmlElement("create_questions")]
        public bool CreateQuestions { get; set; }

        /// <summary>
        /// 生图大小
        /// </summary>
        [XmlElement("draw_size")]
        public NbDrawSize DrawSize { get; set; }

        /// <summary>
        /// 用户输入
        /// </summary>
        [XmlArray("inputs")]
        [XmlArrayItem("nb_input")]
        public List<NbInput> Inputs { get; set; }

        /// <summary>
        /// 预置问题
        /// </summary>
        [XmlArray("prequestions")]
        [XmlArrayItem("string")]
        public List<string> Prequestions { get; set; }

        /// <summary>
        /// 开场白
        /// </summary>
        [XmlElement("prologue")]
        public string Prologue { get; set; }

        /// <summary>
        /// 配置发布时间
        /// </summary>
        [XmlElement("published_time")]
        public string PublishedTime { get; set; }
    }
}
