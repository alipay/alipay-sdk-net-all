using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPluginuseconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPluginuseconfigQueryModel : AopObject
    {
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
        /// 插件appid
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 取值包括WORKING（启用）/WAIT_WORKING(待启用)/STOP_WORKING(停止)/EXECUTING(实施中)
        /// </summary>
        [XmlArray("plugin_relation_status_list")]
        [XmlArrayItem("string")]
        public List<string> PluginRelationStatusList { get; set; }

        /// <summary>
        /// 运行模式，取值包括ONLINE(线上)/TRIAL(联调)
        /// </summary>
        [XmlElement("run_model_type")]
        public string RunModelType { get; set; }
    }
}
