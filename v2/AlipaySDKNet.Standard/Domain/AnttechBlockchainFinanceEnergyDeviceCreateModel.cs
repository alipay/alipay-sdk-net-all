using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyDeviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyDeviceCreateModel : AopObject
    {
        /// <summary>
        /// 地址，当设备为空调、热水器、地暖时必选；
        /// </summary>
        [XmlElement("address")]
        public EntityAddress Address { get; set; }

        /// <summary>
        /// 是否可调节
        /// </summary>
        [XmlElement("adjustable")]
        public bool Adjustable { get; set; }

        /// <summary>
        /// 通信模组
        /// </summary>
        [XmlElement("comm_module_no")]
        public string CommModuleNo { get; set; }

        /// <summary>
        /// 是否仅为控制器  当设备为空调、热水器、地暖时必选；
        /// </summary>
        [XmlElement("controller_only")]
        public bool ControllerOnly { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备专有信息。
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 系统类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备生产商
        /// </summary>
        [XmlElement("manufacturer")]
        public EntityEnterpriseInfo Manufacturer { get; set; }

        /// <summary>
        /// 是否可计量，插座设备必选
        /// </summary>
        [XmlElement("measurable")]
        public bool Measurable { get; set; }

        /// <summary>
        /// 投入运营时间
        /// </summary>
        [XmlElement("operate_date")]
        public string OperateDate { get; set; }

        /// <summary>
        /// 归属主体
        /// </summary>
        [XmlElement("owner_entity")]
        public TrustEntityInfo OwnerEntity { get; set; }

        /// <summary>
        /// 产品合约码
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 设备生产型号
        /// </summary>
        [XmlElement("production_model")]
        public string ProductionModel { get; set; }

        /// <summary>
        /// 额定功率 ，单位 KW  当设备为空调、热水器、地暖时必选；
        /// </summary>
        [XmlElement("rated_power")]
        public string RatedPower { get; set; }

        /// <summary>
        /// 额定电压，单位 V  当设备为空调、热水器、地暖时必选；
        /// </summary>
        [XmlElement("rated_voltage")]
        public string RatedVoltage { get; set; }

        /// <summary>
        /// 响应级别
        /// </summary>
        [XmlElement("response_level")]
        public string ResponseLevel { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        [XmlElement("system_id")]
        public string SystemId { get; set; }

        /// <summary>
        /// 是否可定时
        /// </summary>
        [XmlElement("timeable")]
        public bool Timeable { get; set; }
    }
}
