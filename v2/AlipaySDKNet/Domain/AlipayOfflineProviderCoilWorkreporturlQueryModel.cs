using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCoilWorkreporturlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCoilWorkreporturlQueryModel : AopObject
    {
        /// <summary>
        /// 用于指定某一天的全量报表，由于每日数据产出时效为T+1，通常传入T日日期查询最新报表，例如2025年5月1日的数据会在2025年5月2日产出，传入20250501以查询最新报表
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
