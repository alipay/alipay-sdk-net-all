using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyAggrElectricUserInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyAggrElectricUserInfoDTO : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 年用电量（KWH）范围
        /// </summary>
        [XmlElement("annual_electric_consumption_range")]
        public string AnnualElectricConsumptionRange { get; set; }

        /// <summary>
        /// 是否在国网购电
        /// </summary>
        [XmlElement("buy_electric_from_state_grid")]
        public bool BuyElectricFromStateGrid { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系方式电话
        /// </summary>
        [XmlElement("contact_num")]
        public string ContactNum { get; set; }

        /// <summary>
        /// 用电用户号
        /// </summary>
        [XmlElement("electric_account_id")]
        public string ElectricAccountId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 0-独立缴费 1-缴费到公户 2-缴费到物业
        /// </summary>
        [XmlElement("payment_type")]
        public long PaymentType { get; set; }

        /// <summary>
        /// 省份地区
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("social_credit_code")]
        public string SocialCreditCode { get; set; }
    }
}
