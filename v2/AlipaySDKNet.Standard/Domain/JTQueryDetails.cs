using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JTQueryDetails Data Structure.
    /// </summary>
    [Serializable]
    public class JTQueryDetails : AopObject
    {
        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("bill_code")]
        public string BillCode { get; set; }

        /// <summary>
        /// 轨迹描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 下一站区/县（发件扫描类型时提供）
        /// </summary>
        [XmlElement("next_network_area_name")]
        public string NextNetworkAreaName { get; set; }

        /// <summary>
        /// 下一站城市（发件扫描类型时提供）
        /// </summary>
        [XmlElement("next_network_city_name")]
        public string NextNetworkCityName { get; set; }

        /// <summary>
        /// 下一站省份（发件扫描类型时提供）
        /// </summary>
        [XmlElement("next_network_province_name")]
        public string NextNetworkProvinceName { get; set; }

        /// <summary>
        /// 上一站(到件)或下一站名称(发件)
        /// </summary>
        [XmlElement("next_stop_name")]
        public string NextStopName { get; set; }

        /// <summary>
        /// 枚举值，问题类型
        /// </summary>
        [XmlElement("problem_type")]
        public string ProblemType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 扫描网点区/县
        /// </summary>
        [XmlElement("scan_network_area")]
        public string ScanNetworkArea { get; set; }

        /// <summary>
        /// 扫描网点城市
        /// </summary>
        [XmlElement("scan_network_city")]
        public string ScanNetworkCity { get; set; }

        /// <summary>
        /// 扫描网点联系方式
        /// </summary>
        [XmlElement("scan_network_contact")]
        public string ScanNetworkContact { get; set; }

        /// <summary>
        /// 扫描网点ID
        /// </summary>
        [XmlElement("scan_network_id")]
        public string ScanNetworkId { get; set; }

        /// <summary>
        /// 扫描网点名称
        /// </summary>
        [XmlElement("scan_network_name")]
        public string ScanNetworkName { get; set; }

        /// <summary>
        /// 扫描网点省份
        /// </summary>
        [XmlElement("scan_network_province")]
        public string ScanNetworkProvince { get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        [XmlElement("scan_time")]
        public string ScanTime { get; set; }

        /// <summary>
        /// 枚举值，扫描类型
        /// </summary>
        [XmlElement("scan_type")]
        public string ScanType { get; set; }

        /// <summary>
        /// 业务员联系方式
        /// </summary>
        [XmlElement("staff_contact")]
        public string StaffContact { get; set; }

        /// <summary>
        /// 业务员姓名
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }
    }
}
