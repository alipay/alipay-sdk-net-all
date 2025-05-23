using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdtargetConvertedeventBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdtargetConvertedeventBatchqueryModel : AopObject
    {
        /// <summary>
        /// 该参数表明计划id，可通过计划查询接口获取，或通过计划创建接口的返回值中获取
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 该参数为灯火商家唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 该参数表明排除已转化人群可选择的转化事件的查询维度，包括同计划、同账户 同主体和同商品。
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }
    }
}
