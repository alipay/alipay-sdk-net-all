using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseDataserviceInsighttaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseDataserviceInsighttaskCreateModel : AopObject
    {
        /// <summary>
        /// 洞察品牌
        /// </summary>
        [XmlArray("brands")]
        [XmlArrayItem("insight_brand")]
        public List<InsightBrand> Brands { get; set; }

        /// <summary>
        /// 给客户发放的调用ID
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }

        /// <summary>
        /// 圆的圆心和半径(x,y,r)，半径上下限 0.1~5km，单位为 KM，比如 5000 米，那么输入 r = 5，150 米输入为 r = 0.15
        /// </summary>
        [XmlElement("type_info")]
        public string TypeInfo { get; set; }
    }
}
