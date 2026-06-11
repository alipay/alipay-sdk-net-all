using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentNurseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFulfillmentNurseSyncModel : AopObject
    {
        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 护士ID
        /// </summary>
        [XmlElement("nurse_id")]
        public string NurseId { get; set; }

        /// <summary>
        /// 护士姓名
        /// </summary>
        [XmlElement("nurse_name")]
        public string NurseName { get; set; }

        /// <summary>
        /// 护士状态
        /// </summary>
        [XmlElement("nurse_status")]
        public string NurseStatus { get; set; }

        /// <summary>
        /// 护士状态描述
        /// </summary>
        [XmlElement("nurse_status_desc")]
        public string NurseStatusDesc { get; set; }

        /// <summary>
        /// 护士状态变更时间
        /// </summary>
        [XmlElement("nurse_status_time")]
        public string NurseStatusTime { get; set; }

        /// <summary>
        /// isv履约单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
