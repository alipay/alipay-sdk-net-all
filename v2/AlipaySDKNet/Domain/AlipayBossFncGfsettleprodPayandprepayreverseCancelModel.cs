using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPayandprepayreverseCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodPayandprepayreverseCancelModel : AopObject
    {
        /// <summary>
        /// 应付撤回参数
        /// </summary>
        [XmlElement("active_pay_and_prepay_reverse_cancel_open_api_order")]
        public ActivePayAndPrepayReverseCancelOpenApiOrder ActivePayAndPrepayReverseCancelOpenApiOrder { get; set; }
    }
}
