using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandProductionChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandProductionChangeSyncModel : AopObject
    {
        /// <summary>
        /// 幂等批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 完成当前产线阶段的时间，格式: yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 工序（产线阶段），如：印刷/模切/品检/装配
        /// </summary>
        [XmlElement("production_phase")]
        public string ProductionPhase { get; set; }

        /// <summary>
        /// 项目单号（供应商维度）
        /// </summary>
        [XmlElement("project_no")]
        public string ProjectNo { get; set; }

        /// <summary>
        /// 良品数
        /// </summary>
        [XmlElement("success_amount")]
        public string SuccessAmount { get; set; }
    }
}
