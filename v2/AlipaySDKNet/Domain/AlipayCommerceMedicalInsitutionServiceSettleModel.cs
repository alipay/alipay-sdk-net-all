using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsitutionServiceSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsitutionServiceSettleModel : AopObject
    {
        /// <summary>
        /// 截止时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [XmlElement("indicator_type")]
        public string IndicatorType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
