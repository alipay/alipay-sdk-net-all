using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityBasicInfo : AopObject
    {
        /// <summary>
        /// 小区的建筑类型
        /// </summary>
        [XmlElement("building_type")]
        public string BuildingType { get; set; }

        /// <summary>
        /// 小区的建成时间或修建时间范围
        /// </summary>
        [XmlElement("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 小区的开发企业
        /// </summary>
        [XmlElement("development_enterprise")]
        public string DevelopmentEnterprise { get; set; }

        /// <summary>
        /// 小区的用电类型
        /// </summary>
        [XmlElement("electricity_type")]
        public string ElectricityType { get; set; }

        /// <summary>
        /// 小区的燃气费用，单元：元/立方米
        /// </summary>
        [XmlElement("gas_cost")]
        public string GasCost { get; set; }

        /// <summary>
        /// 小区的绿化率
        /// </summary>
        [XmlElement("greening_rate")]
        public string GreeningRate { get; set; }

        /// <summary>
        /// 小区的供暖费用，单位：元/平米。
        /// </summary>
        [XmlElement("heating_cost")]
        public string HeatingCost { get; set; }

        /// <summary>
        /// 小区的供暖类型
        /// </summary>
        [XmlElement("heating_type")]
        public string HeatingType { get; set; }

        /// <summary>
        /// 小区的物业公司信息
        /// </summary>
        [XmlElement("management_company")]
        public string ManagementCompany { get; set; }

        /// <summary>
        /// 小区物业的电话
        /// </summary>
        [XmlElement("management_mobile")]
        public string ManagementMobile { get; set; }

        /// <summary>
        /// 小区的停车费用，单元：元/月
        /// </summary>
        [XmlElement("parking_cost")]
        public string ParkingCost { get; set; }

        /// <summary>
        /// 小区的车位数量
        /// </summary>
        [XmlElement("parking_number")]
        public long ParkingNumber { get; set; }

        /// <summary>
        /// 小区的容积率
        /// </summary>
        [XmlElement("plot_ratio")]
        public string PlotRatio { get; set; }

        /// <summary>
        /// 小区附近派出所的电话号码
        /// </summary>
        [XmlElement("police_station_mobile")]
        public string PoliceStationMobile { get; set; }

        /// <summary>
        /// 小区附近的派出所名称
        /// </summary>
        [XmlElement("police_station_name")]
        public string PoliceStationName { get; set; }

        /// <summary>
        /// 小区的交易权属
        /// </summary>
        [XmlElement("transaction_ownership")]
        public string TransactionOwnership { get; set; }

        /// <summary>
        /// 小区的用水类型
        /// </summary>
        [XmlElement("water_type")]
        public string WaterType { get; set; }
    }
}
