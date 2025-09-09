using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentBillbatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentBillbatchQueryModel : AopObject
    {
        /// <summary>
        /// 账户编号，租赁机构与公积金中心签约时，公积金系统给租赁机构的账户编号。公积金中心根据此编号绑定租赁机构的收款监管账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账单日期，格式yyyy-mm-dd
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 公积金中心所在城市行政区划代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公积金中心编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }
    }
}
