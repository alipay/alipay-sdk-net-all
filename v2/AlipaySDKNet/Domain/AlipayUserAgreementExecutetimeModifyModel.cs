using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementExecutetimeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementExecutetimeModifyModel : AopObject
    {
        /// <summary>
        /// 代扣协议号。custasset库ca_usage_agreement表的usage_agreementid
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 扣款许可号。mdeduct_ob库mdeduct_permission的主键。
        /// </summary>
        [XmlElement("deduct_permission")]
        public string DeductPermission { get; set; }

        /// <summary>
        /// 修改扣款时间为入参时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 修改类型为扣款许可、扣款执行计划
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }
    }
}
