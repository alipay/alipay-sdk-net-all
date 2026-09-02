using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyImportItem Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyImportItem : AopObject
    {
        /// <summary>
        /// 城市标准名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司在税务局登记的税号
        /// </summary>
        [XmlElement("company_tax_no")]
        public string CompanyTaxNo { get; set; }

        /// <summary>
        /// 联络地址
        /// </summary>
        [XmlElement("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 公司法人或实际运营人或对接支付宝的负责人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 公司联系电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 标识自己的数据来源 可以同商户pid
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 本城市内本公司的司机数
        /// </summary>
        [XmlElement("surveyed_driver_count")]
        public long SurveyedDriverCount { get; set; }

        /// <summary>
        /// 本公司在本城市的运营车辆数
        /// </summary>
        [XmlElement("surveyed_vehicle_count")]
        public long SurveyedVehicleCount { get; set; }
    }
}
