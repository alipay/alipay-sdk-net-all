using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaveDataItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaveDataItemDTO : AopObject
    {
        /// <summary>
        /// 注册授权配置时分配的办事保险箱数据属性key
        /// </summary>
        [XmlElement("attribute_key")]
        public string AttributeKey { get; set; }

        /// <summary>
        /// 认证来源，仅数据认证场景下需要填写（数据提供方appId）
        /// </summary>
        [XmlElement("cert_source")]
        public string CertSource { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_info_d_t_o")]
        public List<FieldInfoDTO> Fields { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("save_record_d_t_o")]
        public List<SaveRecordDTO> Records { get; set; }
    }
}
