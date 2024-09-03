using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentBatchdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentBatchdetailQueryModel : AopObject
    {
        /// <summary>
        /// 公积金中心给租赁企业分配的账户编号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 公积金中心-房租直付发包批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

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
