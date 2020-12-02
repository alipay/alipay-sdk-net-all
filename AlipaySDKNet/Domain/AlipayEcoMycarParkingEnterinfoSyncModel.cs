using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingEnterinfoSyncModel : AopObject
    {
        /// <summary>
        /// 是否启用车牌代扣状态查询功能，true为启用，false为停用
        /// </summary>
        [XmlElement("agreement_query")]
        public bool AgreementQuery { get; set; }

        /// <summary>
        /// 车牌颜色，可选蓝-BLUE、绿-GREEN、黄-YELLOW、白-WHITE、黑-BLACK、黄绿色-LIMEGREEN
        /// </summary>
        [XmlElement("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 用于识别车辆进口，多出入口车场适用
        /// </summary>
        [XmlElement("entrance_id")]
        public string EntranceId { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间
        /// </summary>
        [XmlElement("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID ，系统唯一
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 用于标识车辆停放车位编号，路侧适用
        /// </summary>
        [XmlElement("space_number")]
        public string SpaceNumber { get; set; }

        /// <summary>
        /// 与parking_id对应的外部停车场编号，在门店中维护
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
