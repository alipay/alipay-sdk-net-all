using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOcrMobileInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasOcrMobileInitializeModel : AopObject
    {
        /// <summary>
        /// bizCode，代表当前使用的能力类型。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 客户业务单据号。请保持唯一。
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
