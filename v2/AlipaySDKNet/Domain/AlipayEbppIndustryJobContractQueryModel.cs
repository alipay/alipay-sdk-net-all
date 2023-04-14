using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobContractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobContractQueryModel : AopObject
    {
        /// <summary>
        /// 创建电子合同的订单号
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }
    }
}
