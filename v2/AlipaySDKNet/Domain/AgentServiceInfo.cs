using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgentServiceInfo : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public ServiceExtInfoMap ExtInfos { get; set; }

        /// <summary>
        /// 当服务配置为非直连模式时,才会有值
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 服务的图标
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务展示的优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 埋点信息
        /// </summary>
        [XmlElement("scm_info")]
        public string ScmInfo { get; set; }

        /// <summary>
        /// 服务的副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 服务的标题/名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
