using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeLeaseSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceIncomeLeaseSubmitModel : AopObject
    {
        /// <summary>
        /// 租赁交易登记流水号，用于幂等校验
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 收益分配产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("distribution_pro_no")]
        public string DistributionProNo { get; set; }

        /// <summary>
        /// 租赁合同文件id，根据租赁合同文件上传后返回fileId提供
        /// </summary>
        [XmlElement("lease_contract_file_id")]
        public string LeaseContractFileId { get; set; }

        /// <summary>
        /// 租赁合同编号，请根据实际租赁合同编号提供
        /// </summary>
        [XmlElement("lease_contract_no")]
        public string LeaseContractNo { get; set; }

        /// <summary>
        /// 租赁物列表
        /// </summary>
        [XmlArray("leaseholds")]
        [XmlArrayItem("leaseholds")]
        public List<Leaseholds> Leaseholds { get; set; }

        /// <summary>
        /// 相关方列表，主要提供：出租方、承租方，其中出租方必填
        /// </summary>
        [XmlArray("related_parties")]
        [XmlArrayItem("related_parties")]
        public List<RelatedParties> RelatedParties { get; set; }

        /// <summary>
        /// 每期租金，单位：元，框架租赁合同可不填
        /// </summary>
        [XmlElement("rent_per_period_amount")]
        public string RentPerPeriodAmount { get; set; }

        /// <summary>
        /// 租金结算周期，结合租金结算周期单位提供完整的租金结算周期信息，请提供整数，不带小数点
        /// </summary>
        [XmlElement("rent_settlement_period")]
        public string RentSettlementPeriod { get; set; }

        /// <summary>
        /// 租金结算周期单位，结合租金结算周期提供完整的租金结算周期信息，按枚举值提供
        /// </summary>
        [XmlElement("rent_settlement_period_unit")]
        public string RentSettlementPeriodUnit { get; set; }

        /// <summary>
        /// 租金结算方式，按枚举值填写
        /// </summary>
        [XmlElement("rent_settlement_type")]
        public string RentSettlementType { get; set; }

        /// <summary>
        /// 租金总额，按实际租赁交易合同租金总额填写，单位：元，框架租赁合同可不填
        /// </summary>
        [XmlElement("rent_summary_amount")]
        public string RentSummaryAmount { get; set; }

        /// <summary>
        /// 交易生效时间，根据实际交易发生时间填写，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trade_effect_time")]
        public string TradeEffectTime { get; set; }

        /// <summary>
        /// 交易失效时间，根据实际交易失效时间填写，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trade_expired_time")]
        public string TradeExpiredTime { get; set; }
    }
}
