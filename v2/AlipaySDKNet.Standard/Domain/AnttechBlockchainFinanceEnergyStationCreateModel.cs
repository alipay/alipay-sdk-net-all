using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyStationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyStationCreateModel : AopObject
    {
        /// <summary>
        /// 站点地址
        /// </summary>
        [XmlElement("address")]
        public EntityAddress Address { get; set; }

        /// <summary>
        /// 最大调节持续时间，单位 min
        /// </summary>
        [XmlElement("adjustable_duration_max")]
        public long AdjustableDurationMax { get; set; }

        /// <summary>
        /// 最大可调节的负荷，单位KW
        /// </summary>
        [XmlElement("adjustable_load_max")]
        public string AdjustableLoadMax { get; set; }

        /// <summary>
        /// 建设场所
        /// </summary>
        [XmlElement("construction")]
        public string Construction { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 最大需量 ，单位 KW
        /// </summary>
        [XmlElement("demand_load_max")]
        public string DemandLoadMax { get; set; }

        /// <summary>
        /// 用的户号
        /// </summary>
        [XmlElement("electric_account")]
        public string ElectricAccount { get; set; }

        /// <summary>
        /// 站点投产日期等
        /// </summary>
        [XmlElement("operate_date")]
        public string OperateDate { get; set; }

        /// <summary>
        /// 归属主体
        /// </summary>
        [XmlElement("owner_entity")]
        public TrustEntityInfo OwnerEntity { get; set; }

        /// <summary>
        /// 最大削峰负荷，单位 KW
        /// </summary>
        [XmlElement("peak_shaving_load_max")]
        public string PeakShavingLoadMax { get; set; }

        /// <summary>
        /// 可信价值服务中心产品的合约码，由蚂蚁业务同学完成签约后给到商户
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 总额定功率，单位kw
        /// </summary>
        [XmlElement("rated_power")]
        public string RatedPower { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [XmlElement("service_tel")]
        public string ServiceTel { get; set; }

        /// <summary>
        /// 商户系统中，对应的站点ID等
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点类型
        /// </summary>
        [XmlElement("station_type")]
        public string StationType { get; set; }

        /// <summary>
        /// 变压器负荷上限，单位KW
        /// </summary>
        [XmlElement("transformer_load_max")]
        public string TransformerLoadMax { get; set; }

        /// <summary>
        /// 变压器负荷下限，单位 KW
        /// </summary>
        [XmlElement("transformer_load_min")]
        public string TransformerLoadMin { get; set; }

        /// <summary>
        /// 最大填谷负荷，单位 KW
        /// </summary>
        [XmlElement("valley_filling_load_max")]
        public string ValleyFillingLoadMax { get; set; }

        /// <summary>
        /// 填写的用电户号是否为虚拟户号
        /// </summary>
        [XmlElement("virtual_account")]
        public bool VirtualAccount { get; set; }

        /// <summary>
        /// 电压等级 ，单位 KV
        /// </summary>
        [XmlElement("voltage_level")]
        public string VoltageLevel { get; set; }
    }
}
