using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubContentRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubContentRiskInfo : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("content_file_type")]
        public string ContentFileType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 预处理生成到子素材可访问url,
        /// </summary>
        [XmlElement("generated_url")]
        public string GeneratedUrl { get; set; }

        /// <summary>
        /// ocr详细信息，url方式传输
        /// </summary>
        [XmlElement("ocr_info")]
        public string OcrInfo { get; set; }

        /// <summary>
        /// 外部素材id,代表外部唯一素材
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }

        /// <summary>
        /// 素材风险信息列表 否
        /// </summary>
        [XmlArray("risk_info_list")]
        [XmlArrayItem("risk_info")]
        public List<RiskInfo> RiskInfoList { get; set; }
    }
}
