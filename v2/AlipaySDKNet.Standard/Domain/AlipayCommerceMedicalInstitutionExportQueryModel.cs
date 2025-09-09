using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInstitutionExportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInstitutionExportQueryModel : AopObject
    {
        /// <summary>
        /// 默认传 1d
        /// </summary>
        [XmlElement("aggr_day")]
        public string AggrDay { get; set; }

        /// <summary>
        /// 20250501代表2025年5月1号
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 上海市中医医院
        /// </summary>
        [XmlElement("scc")]
        public string Scc { get; set; }

        /// <summary>
        /// 20250501 表示2025年5月1号
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
