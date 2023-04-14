using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftSettlementmodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftSettlementmodifyModel : AopObject
    {
        /// <summary>
        /// 结算支付宝账号，资金结算到支付宝账号时必填。填入的支付宝账号需已实名认证，且与商户同主体(个体工商户可以与负责人或营业执照名称相同)
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 结算银行卡，如果结算到支付宝账号，则不需要填写。本业务当前只允许传入一张结算卡
        /// </summary>
        [XmlElement("biz_cards")]
        public SettleCardInfo BizCards { get; set; }

        /// <summary>
        /// 默认结算规则。当调用收单接口，结算条款中设置默认结算规则时，交易资金将结算至此处设置的默认结算目标账户中。其详细描述及收单接口传参示例参考功能包文档
        /// </summary>
        [XmlElement("default_settle_rule")]
        public DefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 授权函。当商户名与结算卡户名不一致（模板参考https://gw.alipayobjects.com/os/skylark-tools/public/files/d5fcbe7463d7159a0d362da417d157ed.docx），或涉及外籍法人（这种情况上传任意能证明身份的图片）时必填。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 二级商户支付宝商户号，进件成功后由支付宝返回。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
