using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneProductAgreementQueryResponse.
    /// </summary>
    public class AlipayInsSceneProductAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户签约类型
        /// </summary>
        [XmlElement("agreeement_sign_type")]
        public string AgreeementSignType { get; set; }

        /// <summary>
        /// 商户支付宝2088用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户协议有效期结束时间
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 商户协议生效开始渐渐
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 产品机构产品码
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品协议签约号，协议唯一业务号
        /// </summary>
        [XmlElement("product_sign_no")]
        public string ProductSignNo { get; set; }

        /// <summary>
        /// 签约用户id，根据sign_user_type一致
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约用户类型 ，见字段枚举
        /// </summary>
        [XmlElement("sign_user_type")]
        public string SignUserType { get; set; }

        /// <summary>
        /// 产品状态，见状态枚举
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
