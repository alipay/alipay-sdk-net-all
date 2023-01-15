using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerChargerbindinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerChargerbindinfoSyncModel : AopObject
    {
        /// <summary>
        /// 绑定充电桩二维码值，用户扫码绑桩扫描的二维码
        /// </summary>
        [XmlElement("bind_qrcode")]
        public string BindQrcode { get; set; }

        /// <summary>
        /// 绑定状态 1:绑定; 2:解绑;  0:未知
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 绑定时间，绑定成功必传
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 1：家用插座 2、交流接口插座 3：交流接口插头 4、直流接口枪头 5、无线充电座 6、其他
        /// </summary>
        [XmlElement("connector_type")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// 1：国标 2：欧标 3：美标 4：日标 5：其他
        /// </summary>
        [XmlElement("current_output_type")]
        public string CurrentOutputType { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("equip_id")]
        public string EquipId { get; set; }

        /// <summary>
        /// 设备IMEI号
        /// </summary>
        [XmlElement("equip_imei")]
        public string EquipImei { get; set; }

        /// <summary>
        /// 设备名称，对用户展示，可以是设备名称，也可以是设备SN号，设备编号
        /// </summary>
        [XmlElement("equip_name")]
        public string EquipName { get; set; }

        /// <summary>
        /// 设备SN号
        /// </summary>
        [XmlElement("equip_sn")]
        public string EquipSn { get; set; }

        /// <summary>
        /// 设备状态，遵循中电联协议的设备状态。0：离网;1：空闲;2：占用未充电;3：占用充电中;4：占用（预约锁定）;255：故障
        /// </summary>
        [XmlElement("equip_status")]
        public string EquipStatus { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("equip_type_no")]
        public string EquipTypeNo { get; set; }

        /// <summary>
        /// 运营商编码，一般为企业组织机构代码
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户内部唯一标识用户的用户标识
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 额定电流,单位：A
        /// </summary>
        [XmlElement("rated_current")]
        public string RatedCurrent { get; set; }

        /// <summary>
        /// 额定功率，单位：kW
        /// </summary>
        [XmlElement("rated_power")]
        public string RatedPower { get; set; }

        /// <summary>
        /// 额定电压，单位：V
        /// </summary>
        [XmlElement("rated_voltage")]
        public string RatedVoltage { get; set; }

        /// <summary>
        /// 解绑时间，解绑必传
        /// </summary>
        [XmlElement("unbind_time")]
        public string UnbindTime { get; set; }
    }
}
