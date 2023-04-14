using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginrelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappPluginrelationQueryModel : AopObject
    {
        /// <summary>
        /// 应用ID列表
        /// </summary>
        [XmlArray("mini_app_id_list")]
        [XmlArrayItem("string")]
        public List<string> MiniAppIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件ID
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件使用关系状态，取值包括WORKING/WAIT_WORKING/STOP_WORKING/EXECUTING
        /// </summary>
        [XmlArray("plugin_relation_status_list")]
        [XmlArrayItem("string")]
        public List<string> PluginRelationStatusList { get; set; }

        /// <summary>
        /// 运行类型，取值包括ONLINE/TRIAL/REVIEW/DEBUG
        /// </summary>
        [XmlElement("run_model_type")]
        public string RunModelType { get; set; }

        /// <summary>
        /// 是否展示邀测信息
        /// </summary>
        [XmlElement("show_beta_info")]
        public bool ShowBetaInfo { get; set; }
    }
}
