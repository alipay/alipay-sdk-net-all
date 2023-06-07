using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationPrepareuseResponse.
    /// </summary>
    public class AlipayMarketingCertificateCertificationPrepareuseResponse : AopResponse
    {
        /// <summary>
        /// 凭证信息列表
        /// </summary>
        [XmlArray("certificate_prepare_info_list")]
        [XmlArrayItem("certificate_prepare_info")]
        public List<CertificatePrepareInfo> CertificatePrepareInfoList { get; set; }

        /// <summary>
        /// 凭证归属支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 购买商品的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 凭证归属支付宝用户id，核销接口使用
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
