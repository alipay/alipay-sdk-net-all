using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PageDTO : AopObject
    {
        /// <summary>
        /// 返回的业务数据集合
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("template_version_d_t_o")]
        public List<TemplateVersionDTO> Data { get; set; }

        /// <summary>
        /// 当前页号
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 分页结果total
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
