using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOnepassWebInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasOnepassWebInitializeModel : AopObject
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

        /// <summary>
        /// 用于指定接入平台类型
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
