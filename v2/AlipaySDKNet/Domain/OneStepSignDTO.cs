using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OneStepSignDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OneStepSignDTO : AopObject
    {
        /// <summary>
        /// 业务单据唯一回执单号
        /// </summary>
        [XmlElement("biz_accept_voucher_id")]
        public string BizAcceptVoucherId { get; set; }

        /// <summary>
        /// 合同中心生成的合同编号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 签约方式
        /// </summary>
        [XmlElement("contract_sign_type")]
        public string ContractSignType { get; set; }

        /// <summary>
        /// 签约实例ID，签约系统返回的唯一ID
        /// </summary>
        [XmlElement("sign_instant_id")]
        public string SignInstantId { get; set; }
    }
}
