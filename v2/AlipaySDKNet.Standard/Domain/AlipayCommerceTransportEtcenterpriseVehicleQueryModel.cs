using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseVehicleQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 企业侧车辆编号
        /// </summary>
        [XmlElement("corp_vehicle_id")]
        public string CorpVehicleId { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 企业运单号，同一个corp_id下唯一
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
