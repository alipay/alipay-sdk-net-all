using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersioncontentSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateVersioncontentSaveModel : AopObject
    {
        /// <summary>
        /// 是否直接发布
        /// </summary>
        [XmlElement("direct_publish")]
        public bool DirectPublish { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 预览地址
        /// </summary>
        [XmlElement("preview_address")]
        public string PreviewAddress { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// {   "creatorNo": "360563",   "enumId": null,   "includeAttr": null,   "creatorName": "豫洛",   "elementCode": "CP20240514213023006482",   "templateCode": "T20240514210354040105",   "type": "COMPONENT",   "content": "<component id=\"CP20240514213023006482\" placeholder=\"【甲方名称】\" type=\"INPUT\" enableEdit=\"Y\" required=\"Y\"/>",   "sortValue": 257,   "publicName": "CP20240514213023006482_TE20240514213023040606",   "uk": "TE20240514213023040606",   "name": "【甲方名称】",   "templateVersion": "1",   "tenant": "ANT_ZHIKE" }
        /// </summary>
        [XmlArray("template_element_list")]
        [XmlArrayItem("template_element_link_d_t_o")]
        public List<TemplateElementLinkDTO> TemplateElementList { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
