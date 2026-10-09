using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeDistrictQueryModel : AopObject
    {
        /// <summary>
        /// 父级行政地区编码。 不填则默认查询省级行政地区编码，支持省市县三级查询。
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
