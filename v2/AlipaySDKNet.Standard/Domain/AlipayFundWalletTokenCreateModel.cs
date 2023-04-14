using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTokenCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 如果是ALIPAY_USER_ID，则传用户账号；如果是ALIPAY_LOGIN_ID，则传手机号
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 登陆类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 如果账号类型是ALIPAY_LOGIN_ID，则必传用户真实姓名，进行信息校验
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 场景钱包模版id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
