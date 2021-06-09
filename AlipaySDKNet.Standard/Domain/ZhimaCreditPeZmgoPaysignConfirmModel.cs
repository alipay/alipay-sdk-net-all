using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPaysignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoPaysignConfirmModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 模板关联的appid
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 签约申请的时候返回的操作单号
        /// </summary>
        [XmlElement("zmgo_opt_no")]
        public string ZmgoOptNo { get; set; }
    }
}
