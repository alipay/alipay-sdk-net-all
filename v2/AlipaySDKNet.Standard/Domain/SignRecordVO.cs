using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class SignRecordVO : AopObject
    {
        /// <summary>
        /// 法务C端协议分配的协议ID，用于唯一标识一个协议或复用协议
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 签约记录集合
        /// </summary>
        [XmlArray("log_vos")]
        [XmlArrayItem("sign_record_log_v_o")]
        public List<SignRecordLogVO> LogVos { get; set; }

        /// <summary>
        /// 一般是户号/订单号/2088等； 1、签约与解约保持一致； 2、与离线口径的签约Id保持一致；
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 产品码（产品星球）
        /// </summary>
        [XmlElement("product_cd")]
        public string ProductCd { get; set; }

        /// <summary>
        /// S-签约，U-解约
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
