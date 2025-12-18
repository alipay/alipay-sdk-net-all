using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfinspectionCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfinspectionCompleteModel : AopObject
    {
        /// <summary>
        /// 双方定义
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("reports")]
        [XmlArrayItem("chceck_report")]
        public List<ChceckReport> Reports { get; set; }

        /// <summary>
        /// 履约方定义
        /// </summary>
        [XmlElement("reserve_code")]
        public string ReserveCode { get; set; }
    }
}
