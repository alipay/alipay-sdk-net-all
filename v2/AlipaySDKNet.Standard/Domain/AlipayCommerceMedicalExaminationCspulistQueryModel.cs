using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationCspulistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExaminationCspulistQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("category_id_list")]
        [XmlArrayItem("string")]
        public List<string> CategoryIdList { get; set; }

        /// <summary>
        /// 搜索类目类型
        /// </summary>
        [XmlElement("category_type")]
        public string CategoryType { get; set; }

        /// <summary>
        /// 分页码，可以不传，默认是 ：1
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页大小,可以不传，不传默认：10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 标品或组合品名称,示例：肝功能 14 项
        /// </summary>
        [XmlElement("spu_title")]
        public string SpuTitle { get; set; }
    }
}
