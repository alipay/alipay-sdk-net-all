using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAstoreshopSettleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAstoreshopSettleAddModel : AopObject
    {
        /// <summary>
        /// 银行卡信息（特殊可选），结算到卡时必填 当前字段已废弃(银行卡信息字段位置转入门店结算信息字段中)
        /// </summary>
        [XmlElement("bank_cards")]
        public ShopBankCard BankCards { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlArray("fund_proofs_pic")]
        [XmlArrayItem("string")]
        public List<string> FundProofsPic { get; set; }

        /// <summary>
        /// 资金关系类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("legal_back_pic")]
        public string LegalBackPic { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("legal_front_pic")]
        public string LegalFrontPic { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }

        /// <summary>
        /// 是否承诺收单账号信息准确。具体承诺信息可查看<a href="https://gw.alipayobjects.com/os/bmw-prod/922bafa8-a712-4f79-aa32-6f08d7359a5c.docx">门店信息承诺函</a>。 Y 是 N 否
        /// </summary>
        [XmlElement("promise")]
        public string Promise { get; set; }

        /// <summary>
        /// 门店结算信息
        /// </summary>
        [XmlArray("settle_infos")]
        [XmlArrayItem("shop_settle_info")]
        public List<ShopSettleInfo> SettleInfos { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
