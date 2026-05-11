using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcloudfeereductionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcloudfeereductionCreateModel : AopObject
    {
        /// <summary>
        /// 申请理由
        /// </summary>
        [XmlElement("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 申请BD工号
        /// </summary>
        [XmlElement("bd_work_no")]
        public string BdWorkNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("competitor_list")]
        [XmlArrayItem("sale_force_competitor_d_t_o")]
        public List<SaleForceCompetitorDTO> CompetitorList { get; set; }

        /// <summary>
        /// 券结束时间
        /// </summary>
        [XmlElement("coupon_end_time")]
        public string CouponEndTime { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 券开始时间
        /// </summary>
        [XmlElement("coupon_start_time")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// 券有效期（自定义时间/券发至账户时间当日开始）
        /// </summary>
        [XmlElement("coupon_validity_type")]
        public string CouponValidityType { get; set; }

        /// <summary>
        /// 商机累计ARR
        /// </summary>
        [XmlElement("cumulative_arr")]
        public string CumulativeArr { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// OB的uid
        /// </summary>
        [XmlElement("ob_passport_id")]
        public string ObPassportId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pain_spot_list")]
        [XmlArrayItem("string")]
        public List<string> PainSpotList { get; set; }

        /// <summary>
        /// 减免理由
        /// </summary>
        [XmlElement("reduction_reason")]
        public string ReductionReason { get; set; }

        /// <summary>
        /// 站点（国内站/国际站）
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// salesForce侧唯一幂等键
        /// </summary>
        [XmlElement("sales_force_id")]
        public string SalesForceId { get; set; }

        /// <summary>
        /// 三方uid
        /// </summary>
        [XmlElement("third_party_passport_id")]
        public string ThirdPartyPassportId { get; set; }

        /// <summary>
        /// 选择券发至账户时间当日开始时天数
        /// </summary>
        [XmlElement("time_value")]
        public long TimeValue { get; set; }
    }
}
