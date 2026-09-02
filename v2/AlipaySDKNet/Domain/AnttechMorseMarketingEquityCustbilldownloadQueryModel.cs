using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityCustbilldownloadQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityCustbilldownloadQueryModel : AopObject
    {
        /// <summary>
        /// 根据创建接口获取到的账单任务id
        /// </summary>
        [XmlElement("bill_application_id")]
        public string BillApplicationId { get; set; }
    }
}
