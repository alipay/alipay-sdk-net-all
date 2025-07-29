using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseWaybillUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseWaybillUploadModel : AopObject
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
        /// 企业模式：高速费行程代扣使用企业代扣账户进行代扣，运单上送成功后，企业代扣即刻生效 个人模式：高速费行程代扣使用个人代扣账户进行代扣，运单需进行ETC免密代扣签约，默认为个人模式
        /// </summary>
        [XmlElement("deduct_type")]
        public string DeductType { get; set; }

        /// <summary>
        /// 高速通行费用，单位元，精确到两位小数
        /// </summary>
        [XmlElement("highway_fee")]
        public string HighwayFee { get; set; }

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
        /// 运单目的地
        /// </summary>
        [XmlElement("waybill_end_address")]
        public string WaybillEndAddress { get; set; }

        /// <summary>
        /// 企业运单结束时间
        /// </summary>
        [XmlElement("waybill_end_time")]
        public string WaybillEndTime { get; set; }

        /// <summary>
        /// 运单总费用，单位元，精确到两位小数
        /// </summary>
        [XmlElement("waybill_fee")]
        public string WaybillFee { get; set; }

        /// <summary>
        /// 企业运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// 运单始发地
        /// </summary>
        [XmlElement("waybill_start_address")]
        public string WaybillStartAddress { get; set; }

        /// <summary>
        /// 运单开始时间
        /// </summary>
        [XmlElement("waybill_start_time")]
        public string WaybillStartTime { get; set; }

        /// <summary>
        /// 企业运单状态
        /// </summary>
        [XmlElement("waybill_status")]
        public string WaybillStatus { get; set; }
    }
}
