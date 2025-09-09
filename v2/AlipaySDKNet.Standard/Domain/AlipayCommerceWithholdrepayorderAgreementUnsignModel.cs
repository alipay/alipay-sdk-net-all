using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderAgreementUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdrepayorderAgreementUnsignModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略 。 本参数与 external_agreement_no 不可同时为空。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 代扣协议中标示用户的唯一签约号(确保在商户系统中 唯一)。 格式规则:支持大写小写字母和数字，最长 32 位。若同时传入agreement_no则优先agreement_no。注意：若调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时传入 external_agreement_no 则该值必填且需与签约接口传入值相同。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 注意：仅异步解约需传入，其余情况无需传递本参数。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约协议场景，该值需要与系统/页面签约接口调用时传入的值保持一 致。如：周期扣款场景，需与调用 alipay.user.agreement.page.sign(支付宝个人协议页面签约接口) 签约时的 sign_scene 相同。 当传入商户签约号 external_agreement_no时，场景不能为空或默认值 DEFAULT|DEFAULT。
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。
        /// </summary>
        [XmlElement("third_party_type")]
        public string ThirdPartyType { get; set; }
    }
}
