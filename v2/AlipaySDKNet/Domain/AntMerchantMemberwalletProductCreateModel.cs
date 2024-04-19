using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletProductCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletProductCreateModel : AopObject
    {
        /// <summary>
        /// 会员钱包名称
        /// </summary>
        [XmlElement("member_wallet_name")]
        public string MemberWalletName { get; set; }

        /// <summary>
        /// 会员钱包产品类型： <br>platform 平台钱包 <br>studio 直播间钱包 <br>merchant 商户钱包
        /// </summary>
        [XmlElement("member_wallet_type")]
        public string MemberWalletType { get; set; }

        /// <summary>
        /// 外部业务唯一流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 会员钱包使用场景ID <br>直播间钱包传外部直播间唯一标识 <br>商户钱包传支付宝商户ID
        /// </summary>
        [XmlElement("out_scene_id")]
        public string OutSceneId { get; set; }
    }
}
