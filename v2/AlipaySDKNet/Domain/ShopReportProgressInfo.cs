using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopReportProgressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopReportProgressInfo : AopObject
    {
        /// <summary>
        /// 当前上报进度阶段
        /// </summary>
        [XmlElement("current_stage")]
        public string CurrentStage { get; set; }

        /// <summary>
        /// 上报进度在此阶段下的具体状态
        /// </summary>
        [XmlElement("current_stage_status")]
        public string CurrentStageStatus { get; set; }

        /// <summary>
        /// 其他补充的描述信息，如风控结果信息等
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 上报结果
        /// </summary>
        [XmlElement("report_result")]
        public string ReportResult { get; set; }

        /// <summary>
        /// A+店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
