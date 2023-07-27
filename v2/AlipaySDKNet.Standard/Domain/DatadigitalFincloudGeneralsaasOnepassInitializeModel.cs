using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOnepassInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasOnepassInitializeModel : AopObject
    {
        /// <summary>
        /// 客户业务单据号。
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// 待校验的手机号。
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
