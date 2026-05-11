using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalMaterialSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalMaterialSyncModel : AopObject
    {
        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("material_query_attachment_d_t_o")]
        public List<MaterialQueryAttachmentDTO> Attachments { get; set; }

        /// <summary>
        /// 认证单位
        /// </summary>
        [XmlElement("certification_unit")]
        public string CertificationUnit { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 资料查询编号
        /// </summary>
        [XmlElement("material_no")]
        public string MaterialNo { get; set; }

        /// <summary>
        /// 资料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("valid_until")]
        public string ValidUntil { get; set; }
    }
}
