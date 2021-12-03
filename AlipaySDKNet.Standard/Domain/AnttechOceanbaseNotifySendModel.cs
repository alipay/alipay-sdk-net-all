using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseNotifySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseNotifySendModel : AopObject
    {
        /// <summary>
        /// 用户通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 通知枚举:CLOUD_DELETE_CLUSTER_FAILED多云删除集群失败。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 模板占位符信息列表
        /// </summary>
        [XmlArray("template_placeholder_list")]
        [XmlArrayItem("template_placeholder_d_t_o")]
        public List<TemplatePlaceholderDTO> TemplatePlaceholderList { get; set; }
    }
}
