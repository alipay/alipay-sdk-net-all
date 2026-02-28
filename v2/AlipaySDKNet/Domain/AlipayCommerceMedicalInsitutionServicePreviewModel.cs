using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsitutionServicePreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsitutionServicePreviewModel : AopObject
    {
        /// <summary>
        /// 数据日期
        /// </summary>
        [XmlElement("data_dt")]
        public string DataDt { get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [XmlElement("indicator_type")]
        public string IndicatorType { get; set; }
    }
}
