using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceSceneBasicVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSceneBasicVO : AopObject
    {
        /// <summary>
        /// 渠道列表
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("service_scene_channel_v_o")]
        public List<ServiceSceneChannelVO> Channels { get; set; }

        /// <summary>
        /// 场景版本ID
        /// </summary>
        [XmlElement("scene_info_id")]
        public string SceneInfoId { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 作业模式
        /// </summary>
        [XmlElement("service_mode")]
        public string ServiceMode { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [XmlElement("service_scene_id")]
        public string ServiceSceneId { get; set; }

        /// <summary>
        /// 解决方案编码
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
