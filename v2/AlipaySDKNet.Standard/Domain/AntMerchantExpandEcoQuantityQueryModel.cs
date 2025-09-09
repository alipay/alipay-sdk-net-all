using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoQuantityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoQuantityQueryModel : AopObject
    {
        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 查询年月 格式：yyyyMM
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }
    }
}
