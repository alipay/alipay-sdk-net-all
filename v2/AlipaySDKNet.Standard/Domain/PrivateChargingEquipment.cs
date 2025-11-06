using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrivateChargingEquipment Data Structure.
    /// </summary>
    [Serializable]
    public class PrivateChargingEquipment : AopObject
    {
        /// <summary>
        /// 充电桩二维码值
        /// </summary>
        [XmlElement("bind_qrcode")]
        public string BindQrcode { get; set; }

        /// <summary>
        /// 设备接口类型
        /// </summary>
        [XmlElement("connector_type")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// 设备输出接口类型
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
        [XmlElement("equip_imei_no")]
        public string EquipImeiNo { get; set; }

        /// <summary>
        /// 充电桩名称
        /// </summary>
        [XmlElement("equip_name")]
        public string EquipName { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("equip_sn")]
        public string EquipSn { get; set; }

        /// <summary>
        /// 充电桩的设备类型。智能开关是指与无联网功能充电桩配套使用的可以联网控制充放电的开关
        /// </summary>
        [XmlElement("equip_type")]
        public string EquipType { get; set; }

        /// <summary>
        /// 设备型号编码
        /// </summary>
        [XmlElement("equip_type_no")]
        public string EquipTypeNo { get; set; }

        /// <summary>
        /// 启动模式
        /// </summary>
        [XmlArray("modes")]
        [XmlArrayItem("string")]
        public List<string> Modes { get; set; }

        /// <summary>
        /// 充电桩设备的联网流量生效时间，一般指4G流量卡或者物联网有效的起始时间
        /// </summary>
        [XmlElement("network_data_begin_time")]
        public string NetworkDataBeginTime { get; set; }

        /// <summary>
        /// 充电桩设备的联网流量失效时间，一般指4G流量卡或者物联网的失效时间
        /// </summary>
        [XmlElement("network_data_end_time")]
        public string NetworkDataEndTime { get; set; }

        /// <summary>
        /// 充电桩的额定电流，单位为安倍（A），请传入转换单位后的数值
        /// </summary>
        [XmlElement("rated_current")]
        public string RatedCurrent { get; set; }

        /// <summary>
        /// 充电桩的额定功率，单位为千瓦（kW），请传入转换单位后的数值
        /// </summary>
        [XmlElement("rated_power")]
        public string RatedPower { get; set; }

        /// <summary>
        /// 充电桩的额定电压，单位为伏特（V），请传入转换单位后的数值
        /// </summary>
        [XmlElement("rated_voltage")]
        public string RatedVoltage { get; set; }

        /// <summary>
        /// 充电桩设备的关联二级品牌商编号，一般指生产商或制造商。若需要关联二级品牌商，则需要传入
        /// </summary>
        [XmlElement("s_brand_code")]
        public string SBrandCode { get; set; }
    }
}
