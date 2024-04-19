using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户开通钱包时的外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户主体标识
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户主体标识
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// alipay_user_id代表支付宝用户id mechant_user_id代表商户id
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 查询不同场景信息 WALLET_INFO：查用户钱包 WITHDRAW_INFO：原路退资金 DESTROY_INFO：销户资金查询
        /// </summary>
        [XmlElement("search_type")]
        public string SearchType { get; set; }

        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 该字段适合用于外部商户不知道用户钱包ID的情况下，通过钱包模板ID+用户user_id反查用户钱包ID。因此，钱包模板ID不为空的情况下，principal_id和principal_type一定不能为空。
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
