using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CampOrderInfo : AopObject
    {
        /// <summary>
        /// 抽奖平台活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动单据ID
        /// </summary>
        [XmlElement("camp_order_id")]
        public string CampOrderId { get; set; }

        /// <summary>
        /// 外部单号ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 活动单据主状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
