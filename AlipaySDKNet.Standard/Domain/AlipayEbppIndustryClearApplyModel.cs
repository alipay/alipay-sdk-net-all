using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryClearApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryClearApplyModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("business_date")]
        public string BusinessDate { get; set; }

        /// <summary>
        /// 机构请款的备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 请款编号
        /// </summary>
        [XmlElement("passive_no")]
        public string PassiveNo { get; set; }

        /// <summary>
        /// 子机构编码
        /// </summary>
        [XmlElement("sub_org_code")]
        public string SubOrgCode { get; set; }
    }
}
