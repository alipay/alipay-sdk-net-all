using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrivateChargingOrder Data Structure.
    /// </summary>
    [Serializable]
    public class PrivateChargingOrder : AopObject
    {
        /// <summary>
        /// A相电流。单位A，含直流（输出）
        /// </summary>
        [XmlElement("current_a")]
        public string CurrentA { get; set; }

        /// <summary>
        /// B相电流
        /// </summary>
        [XmlElement("current_b")]
        public string CurrentB { get; set; }

        /// <summary>
        /// C相电流
        /// </summary>
        [XmlElement("current_c")]
        public string CurrentC { get; set; }

        /// <summary>
        /// 累计电费
        /// </summary>
        [XmlElement("elec_money")]
        public string ElecMoney { get; set; }

        /// <summary>
        /// 充电结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("equip_id")]
        public string EquipId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商家用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 本次采样时间
        /// </summary>
        [XmlElement("sample_time")]
        public string SampleTime { get; set; }

        /// <summary>
        /// 电池剩余电量
        /// </summary>
        [XmlElement("soc")]
        public string Soc { get; set; }

        /// <summary>
        /// 充电订单号
        /// </summary>
        [XmlElement("start_charge_seq")]
        public string StartChargeSeq { get; set; }

        /// <summary>
        /// 充电订单状态
        /// </summary>
        [XmlElement("start_charge_seq_stat")]
        public string StartChargeSeqStat { get; set; }

        /// <summary>
        /// 开始充电时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 累计充电量
        /// </summary>
        [XmlElement("total_power")]
        public string TotalPower { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// A相电压。单位V，含直流（输出）
        /// </summary>
        [XmlElement("voltage_a")]
        public string VoltageA { get; set; }

        /// <summary>
        /// B相电压
        /// </summary>
        [XmlElement("voltage_b")]
        public string VoltageB { get; set; }

        /// <summary>
        /// C相电压
        /// </summary>
        [XmlElement("voltage_c")]
        public string VoltageC { get; set; }
    }
}
