using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PayConfig : AopObject
    {
        /// <summary>
        /// 银行渠道模式。YES时必传，可选的字段枚举说明：{BANK:指定银行;BANK_CARD:指定银行卡；BIN:指定银行BIN}
        /// </summary>
        [XmlElement("bank_channel_mode")]
        public string BankChannelMode { get; set; }

        /// <summary>
        /// 持卡人姓名
        /// </summary>
        [XmlElement("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// BANK_CARD时必传银行卡号，BIN时必传银行识别码
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开通资产角色，只针对银行模式（指定银行，指定银行卡，指定卡bin）；不传默认为 PARENT
        /// </summary>
        [XmlElement("open_asset_role")]
        public string OpenAssetRole { get; set; }

        /// <summary>
        /// 是否单开户，默认为false。开通家长小荷包时必选
        /// </summary>
        [XmlElement("open_single_account")]
        public bool OpenSingleAccount { get; set; }

        /// <summary>
        /// 使用银行渠道。可选的字段枚举说明：{YES:使用银行渠道;NO:使用支付宝默认扣款顺序} 注意：当指定使用银行渠道时，务必提前联系您的BD配置对应学校的银行
        /// </summary>
        [XmlElement("use_bank_channel")]
        public string UseBankChannel { get; set; }
    }
}
