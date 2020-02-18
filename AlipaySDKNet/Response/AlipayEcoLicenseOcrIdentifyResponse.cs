using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoLicenseOcrIdentifyResponse.
    /// </summary>
    public class AlipayEcoLicenseOcrIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("person")]
        public string Person { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
