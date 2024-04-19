using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspCreative Data Structure.
    /// </summary>
    [Serializable]
    public class DspCreative : AopObject
    {
        /// <summary>
        /// 应用下载
        /// </summary>
        [XmlArray("app_download")]
        [XmlArrayItem("dsp_app_download")]
        public List<DspAppDownload> AppDownload { get; set; }

        /// <summary>
        /// 创意内容元数据列表
        /// </summary>
        [XmlArray("creative_elements")]
        [XmlArrayItem("dsp_creative_element")]
        public List<DspCreativeElement> CreativeElements { get; set; }

        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 创意标签，包含创意来源等信息
        /// </summary>
        [XmlArray("creative_tags")]
        [XmlArrayItem("string")]
        public List<string> CreativeTags { get; set; }

        /// <summary>
        /// 唤端链接
        /// </summary>
        [XmlElement("deeplink_url")]
        public string DeeplinkUrl { get; set; }

        /// <summary>
        /// 素材失效日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 创意生效时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 行业id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
