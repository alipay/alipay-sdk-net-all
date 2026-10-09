using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GrasslandCert Data Structure.
    /// </summary>
    [Serializable]
    public class GrasslandCert : AopObject
    {
        /// <summary>
        /// 证书生成时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 待种植
        /// </summary>
        [XmlElement("cert_stamp")]
        public string CertStamp { get; set; }

        /// <summary>
        /// 证书id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 展示信息
        /// </summary>
        [XmlElement("display_info")]
        public string DisplayInfo { get; set; }

        /// <summary>
        /// 赞助商图标
        /// </summary>
        [XmlElement("donator_image")]
        public string DonatorImage { get; set; }

        /// <summary>
        /// 能量值，单位克(g)
        /// </summary>
        [XmlElement("energy")]
        public long Energy { get; set; }

        /// <summary>
        /// 公益机构名称
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 公益机构图标
        /// </summary>
        [XmlElement("organization_icon_url")]
        public string OrganizationIconUrl { get; set; }

        /// <summary>
        /// 种植几号林
        /// </summary>
        [XmlElement("plant_place")]
        public string PlantPlace { get; set; }

        /// <summary>
        /// 树种项目id
        /// </summary>
        [XmlElement("project_id")]
        public long ProjectId { get; set; }

        /// <summary>
        /// 项目的名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 种植地区
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 种植地区编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 树模版id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 项目模板名称
        /// </summary>
        [XmlElement("tree_name")]
        public string TreeName { get; set; }

        /// <summary>
        /// 证书子类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
