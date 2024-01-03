using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonAgreementSignModel : AopObject
    {
        /// <summary>
        /// 约定值，参考业务接入文档
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 签约时间，毫秒级时间戳 out_sign_no+biz_date为请求幂等键，biz_date小于等于数据库值的签约请求幂等返回
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 用户open_id，用户在app_id下的唯一id，请优先使用open_id，user_id将逐步下线
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部签约号，app_id下唯一
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 签约扩展内容，字段参考业务接入文档
        /// </summary>
        [XmlElement("sign_content")]
        public SignContentParams SignContent { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
