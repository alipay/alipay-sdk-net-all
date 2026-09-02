using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingEquityCustbilldownloadtaskCreateResponse.
    /// </summary>
    public class AnttechMorseMarketingEquityCustbilldownloadtaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 根据创建接口获取到的账单任务id
        /// </summary>
        [XmlElement("bill_application_id")]
        public string BillApplicationId { get; set; }
    }
}
