using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOneloginInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasOneloginInitializeModel : AopObject
    {
        /// <summary>
        /// 客户业务单据号。
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
