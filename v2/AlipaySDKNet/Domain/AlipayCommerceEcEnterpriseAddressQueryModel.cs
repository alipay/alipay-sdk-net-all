using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseAddressQueryModel : AopObject
    {
        /// <summary>
        /// 共同账户id和enterprise_id二选一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 协议号，如果填共同账户id，则该字段必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 企业id和account_id二选一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 页码从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
