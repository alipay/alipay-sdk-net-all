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
        /// 公积金中心编号
        /// </summary>
        [XmlElement("accfund_center_no")]
        public string AccfundCenterNo { get; set; }

        /// <summary>
        /// 公积金中心给租赁企业分配的账户编号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 公积金中心-房租直付发包批次号，当是按批次查询的时候，只需要传batch_no，page_num和page_size就不需要传
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 账单日期，格式：yyyy-mm-dd
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

        /// <summary>
        /// 查询页数，当是分页查询的时候，page_num和page_size就是必选字段，batch_no就不需要传
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页条数，当是分页查询的时候，page_num和page_size就是必选字段，batch_no就不需要传
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
