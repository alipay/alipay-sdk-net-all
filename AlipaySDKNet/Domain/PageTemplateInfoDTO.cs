using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageTemplateInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PageTemplateInfoDTO : AopObject
    {
        /// <summary>
        /// 模版code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// creator_id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("current_version")]
        public long CurrentVersion { get; set; }

        /// <summary>
        /// 最新的编辑态版本
        /// </summary>
        [XmlElement("edit_version")]
        public long EditVersion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// code第一次创建时间
        /// </summary>
        [XmlElement("gmt_create_code")]
        public string GmtCreateCode { get; set; }

        /// <summary>
        /// 最后的修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// modifier_id
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// modifier_name
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 模版名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参数模版列表
        /// </summary>
        [XmlArray("param_template_list")]
        [XmlArrayItem("page_template_param_info_d_t_o")]
        public List<PageTemplateParamInfoDTO> ParamTemplateList { get; set; }

        /// <summary>
        /// 图片的cdn地址
        /// </summary>
        [XmlElement("picture_url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 模版预览url
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 后端解析器
        /// </summary>
        [XmlElement("resolve_code")]
        public string ResolveCode { get; set; }

        /// <summary>
        /// 运行的版本
        /// </summary>
        [XmlElement("run_version")]
        public long RunVersion { get; set; }

        /// <summary>
        /// 模版类型， 具体值定义参考 PageTemplateTypeEnum
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
