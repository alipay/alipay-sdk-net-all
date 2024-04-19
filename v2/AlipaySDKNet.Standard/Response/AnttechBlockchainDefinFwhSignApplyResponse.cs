using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinFwhSignApplyResponse.
    /// </summary>
    public class AnttechBlockchainDefinFwhSignApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理号
        /// </summary>
        [XmlElement("accepted_no")]
        public string AcceptedNo { get; set; }

        /// <summary>
        /// 授权商家会员id
        /// </summary>
        [XmlElement("merchant_member_id")]
        public string MerchantMemberId { get; set; }

        /// <summary>
        /// 用户签约号，协议中标识用户的唯一签约号
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }

        /// <summary>
        /// 签约链接，可通过二维码生成工具将该字符串转成二维码，用户进行扫码签约
        /// </summary>
        [XmlElement("sign_link")]
        public string SignLink { get; set; }
    }
}
