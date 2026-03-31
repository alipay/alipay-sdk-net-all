using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportOptionVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportOptionVO : AopObject
    {
        /// <summary>
        /// 是否缺陷项
        /// </summary>
        [XmlElement("defect_option")]
        public bool DefectOption { get; set; }

        /// <summary>
        /// 问题选项编码
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 问题选项图片Id列表
        /// </summary>
        [XmlArray("option_image_id_list")]
        [XmlArrayItem("string")]
        public List<string> OptionImageIdList { get; set; }

        /// <summary>
        /// 问题选项图片url列表
        /// </summary>
        [XmlArray("option_image_url_list")]
        [XmlArrayItem("string")]
        public List<string> OptionImageUrlList { get; set; }

        /// <summary>
        /// 问题选项名称
        /// </summary>
        [XmlElement("option_name")]
        public string OptionName { get; set; }
    }
}
