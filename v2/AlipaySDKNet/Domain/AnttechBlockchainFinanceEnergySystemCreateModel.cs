using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergySystemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergySystemCreateModel : AopObject
    {
        /// <summary>
        /// 是否可调节
        /// </summary>
        [XmlElement("adjustable")]
        public bool Adjustable { get; set; }

        /// <summary>
        /// 能源系统投产日期
        /// </summary>
        [XmlElement("operate_date")]
        public string OperateDate { get; set; }

        /// <summary>
        /// 归属主体
        /// </summary>
        [XmlElement("owner_entity")]
        public TrustEntityInfo OwnerEntity { get; set; }

        /// <summary>
        /// 可信价值服务中心产品的合约码，由蚂蚁业务同学完成签约后给到商户
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 总额定功率，单位KW
        /// </summary>
        [XmlElement("rated_power_sum")]
        public string RatedPowerSum { get; set; }

        /// <summary>
        /// 响应级别
        /// </summary>
        [XmlElement("response_level")]
        public string ResponseLevel { get; set; }

        /// <summary>
        /// 场站编码
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 能源系统编号
        /// </summary>
        [XmlElement("system_id")]
        public string SystemId { get; set; }

        /// <summary>
        /// 系统的专属信息。
        /// </summary>
        [XmlElement("system_info")]
        public string SystemInfo { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [XmlElement("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 系统状态
        /// </summary>
        [XmlElement("system_status")]
        public string SystemStatus { get; set; }

        /// <summary>
        /// 系统类型
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }
    }
}
