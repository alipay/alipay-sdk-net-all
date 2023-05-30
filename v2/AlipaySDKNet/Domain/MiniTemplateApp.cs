using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniTemplateApp Data Structure.
    /// </summary>
    [Serializable]
    public class MiniTemplateApp : AopObject
    {
        /// <summary>
        /// 小程序模板应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用创建时间
        /// </summary>
        [XmlElement("date_create")]
        public string DateCreate { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 小程序应用id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模板版本列表
        /// </summary>
        [XmlArray("version_list")]
        [XmlArrayItem("mini_template_version_info")]
        public List<MiniTemplateVersionInfo> VersionList { get; set; }
    }
}
