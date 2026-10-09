using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAlcagmprodAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAlcagmprodAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 法务C端协议分配的协议ID，用于唯一标识一个协议或复用协议。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
