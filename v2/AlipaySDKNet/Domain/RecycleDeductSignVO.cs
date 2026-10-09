using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeductSignVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeductSignVO : AopObject
    {
        /// <summary>
        /// 2088脱敏展示
        /// </summary>
        [XmlElement("deduct_sign_pid")]
        public string DeductSignPid { get; set; }

        /// <summary>
        /// SIGN已签约UNSIGN未签约
        /// </summary>
        [XmlElement("deduct_sign_status")]
        public string DeductSignStatus { get; set; }

        /// <summary>
        /// 回收个人版代扣签约INDIVIDUAL 回收企业版代扣签约ENTERPRISE
        /// </summary>
        [XmlElement("deduct_sign_type")]
        public string DeductSignType { get; set; }
    }
}
