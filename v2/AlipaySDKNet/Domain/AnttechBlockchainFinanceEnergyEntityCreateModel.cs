using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyEntityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceEnergyEntityCreateModel : AopObject
    {
        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("device_info")]
        public TrustDeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// 实体地址
        /// </summary>
        [XmlElement("entity_address")]
        public EntityAddress EntityAddress { get; set; }

        /// <summary>
        /// 实体名称，如站点名称、户名等
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类型，如站点、能源系统、终端设备
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 实体相关的业务时间，如站点投产日期等
        /// </summary>
        [XmlElement("operate_date")]
        public string OperateDate { get; set; }

        /// <summary>
        /// 实体运营企业
        /// </summary>
        [XmlElement("operator_enterprise")]
        public EntityEnterpriseInfo OperatorEnterprise { get; set; }

        /// <summary>
        /// 商户系统中，对应的实体编号。 如户号、站点ID、虚拟电厂ID等
        /// </summary>
        [XmlElement("out_entity_id")]
        public string OutEntityId { get; set; }

        /// <summary>
        /// 实体归属企业信息
        /// </summary>
        [XmlElement("owner_enterprise")]
        public EntityEnterpriseInfo OwnerEnterprise { get; set; }

        /// <summary>
        /// 父级实体的Id，当商户创建的实体之间存在关联关系时，必须先创建父级实体，再创建子实体。 子实体创建时，父级实体不能为空。不然无法创建实体建关系。
        /// </summary>
        [XmlElement("parent_out_entity_id")]
        public string ParentOutEntityId { get; set; }

        /// <summary>
        /// 可信价值服务中心产品的合约码，由蚂蚁业务同学完成签约后给到商户
        /// </summary>
        [XmlElement("product_agreement_code")]
        public string ProductAgreementCode { get; set; }

        /// <summary>
        /// 站点信息
        /// </summary>
        [XmlElement("station_info")]
        public TrustStationInfo StationInfo { get; set; }

        /// <summary>
        /// 能源系统信息
        /// </summary>
        [XmlElement("system_info")]
        public TrustSystemInfo SystemInfo { get; set; }
    }
}
