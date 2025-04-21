using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsPointWorkModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsPointWorkModifyModel : AopObject
    {
        /// <summary>
        /// 新的铺设点描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 当前变更的线圈ID。如果该值为空，支付宝会用old_point_id+old_place_id定位到当前变更的点位和铺设点
        /// </summary>
        [XmlElement("logistics_nfc_id")]
        public string LogisticsNfcId { get; set; }

        /// <summary>
        /// 变更后的铺设点ID。 在移撤场景下，该值可为空。其它场景下，该值不能为空
        /// </summary>
        [XmlElement("new_place_id")]
        public string NewPlaceId { get; set; }

        /// <summary>
        /// 变更后的铺设点名称。 在移撤场景下，该值可为空。其它场景下，该值不能为空
        /// </summary>
        [XmlElement("new_place_name")]
        public string NewPlaceName { get; set; }

        /// <summary>
        /// 变更后的点位ID。在移撤场景下，该值可为空。其它场景下，该值不能为空
        /// </summary>
        [XmlElement("new_point_id")]
        public string NewPointId { get; set; }

        /// <summary>
        /// 变更后的点位名称。 在移撤场景下，该值可为空。其它场景下，该值不能为空
        /// </summary>
        [XmlElement("new_point_name")]
        public string NewPointName { get; set; }

        /// <summary>
        /// 当前铺设点上的线圈状态
        /// </summary>
        [XmlElement("nfc_status")]
        public string NfcStatus { get; set; }

        /// <summary>
        /// 变更前的点位ID
        /// </summary>
        [XmlElement("old_point_id")]
        public string OldPointId { get; set; }

        /// <summary>
        /// 本此的变更类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 变更前的铺设点ID
        /// </summary>
        [XmlElement("out_place_id")]
        public string OutPlaceId { get; set; }

        /// <summary>
        /// 变更后的铺设点地址。
        /// </summary>
        [XmlElement("work_place_address")]
        public BusinessAddress WorkPlaceAddress { get; set; }

        /// <summary>
        /// 变更后的点位地址。 在撤柜场景下，该值可为空。其它场景下，该值不能为空
        /// </summary>
        [XmlElement("work_point_address")]
        public BusinessAddress WorkPointAddress { get; set; }
    }
}
