using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentHousingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentHousingQueryModel : AopObject
    {
        /// <summary>
        /// 租房平台账单业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
