using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTDeliveryPlan Data Structure.
    /// </summary>
    [Serializable]
    public class IoTDeliveryPlan : AopObject
    {
        /// <summary>
        /// 投放计划基础信息。
        /// </summary>
        [XmlElement("delivery_base_info")]
        public IotDeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 投放的展位编码
        /// </summary>
        [XmlElement("delivery_booth_code")]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// 投放错误信息（如有）
        /// </summary>
        [XmlElement("delivery_error_msg")]
        public string DeliveryErrorMsg { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 投放计划玩法配置
        /// </summary>
        [XmlElement("delivery_play_config")]
        public IotDeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// 投放计划状态。  枚举值：  ACTIVE：生效中  OFFLINE：已下线  PUBLISHING：发布中 。 注意发布中状态可能会停留1~5分钟，然后进入生效中或发布失败状态。 FAIL：发布失败
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
