using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDataQueryModel : AopObject
    {
        /// <summary>
        /// 测试复杂类型审批
        /// </summary>
        [XmlElement("hello_hq")]
        public HelloHq HelloHq { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
