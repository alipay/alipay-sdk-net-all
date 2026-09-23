using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCheckitemStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCheckitemStatusSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_item_data_list")]
        [XmlArrayItem("check_order_data")]
        public List<CheckOrderData> CheckItemDataList { get; set; }

        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 履约单号 当前字段已废弃(履约单号字段英文名有修改)
        /// </summary>
        [XmlElement("fulfillment_on")]
        public string FulfillmentOn { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 2088用户UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
