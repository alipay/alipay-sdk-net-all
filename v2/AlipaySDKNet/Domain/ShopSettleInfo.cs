using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopSettleInfo : AopObject
    {
        /// <summary>
        /// 结算到户的账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 结算收款方主体类型，未准入可结算个人户的商户可忽略
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 门店结算银行卡信息（特殊可选），结算到卡时必填
        /// </summary>
        [XmlElement("bank_cards")]
        public ShopBankCard BankCards { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 身份证反面图片id，需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("payee_identity_back_pic")]
        public string PayeeIdentityBackPic { get; set; }

        /// <summary>
        /// 身份证正面图片id，需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("payee_identity_front_pic")]
        public string PayeeIdentityFrontPic { get; set; }

        /// <summary>
        /// 门头照图片id，需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("shop_front_pic")]
        public string ShopFrontPic { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
