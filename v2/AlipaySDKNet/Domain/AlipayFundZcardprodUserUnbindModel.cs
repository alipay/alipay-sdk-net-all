using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundZcardprodUserUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundZcardprodUserUnbindModel : AopObject
    {
        /// <summary>
        /// 账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 通用商店
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 当签约方类型是ALIPAY_USER_ID时，本参数为用户的支付宝账号userId，以2088开头的纯16位数字； 当签约方类型是ALIPAY_LOGON_ID时，本参数为用户的支付宝登录号。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// ALIPAY_USER_ID：表示是支付宝账号userId；ALIPAY_LOGON_ID：表示是支付宝登录号
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }

        /// <summary>
        /// 支卡通
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }
    }
}
