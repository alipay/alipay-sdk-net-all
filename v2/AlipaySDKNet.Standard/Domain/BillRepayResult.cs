using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillRepayResult Data Structure.
    /// </summary>
    [Serializable]
    public class BillRepayResult : AopObject
    {
        /// <summary>
        /// 还款错误码，失败时有值
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息（错误文案），失败时有值
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 还款结果 SUCC: 成功 FAIL: 失败 EXEC: 还款中
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
