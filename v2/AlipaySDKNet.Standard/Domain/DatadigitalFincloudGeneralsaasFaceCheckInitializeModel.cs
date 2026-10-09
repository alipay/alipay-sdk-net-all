using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCheckInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceCheckInitializeModel : AopObject
    {
        /// <summary>
        /// DATA_DIGITAL_BIZ_CODE_FACE_CHECK_LIVE，代表活体检测。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 客户业务单据号。
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
