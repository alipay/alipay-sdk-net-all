using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalPayerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalPayerInfo : AopObject
    {
        /// <summary>
        /// 机构卡信息
        /// </summary>
        [XmlElement("out_inst_card_no")]
        public string OutInstCardNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("out_inst_payer_inst_id")]
        public string OutInstPayerInstId { get; set; }

        /// <summary>
        /// 代理企业支付中，企业的名称
        /// </summary>
        [XmlElement("out_payer_account_name")]
        public string OutPayerAccountName { get; set; }
    }
}
