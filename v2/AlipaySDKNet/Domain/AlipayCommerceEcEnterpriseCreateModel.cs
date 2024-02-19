using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseCreateModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否设置管理员支付宝为企业出资账户
        /// </summary>
        [XmlElement("create_fund_account")]
        public bool CreateFundAccount { get; set; }

        /// <summary>
        /// 是否创建企业人脸库，适用于对接团餐刷脸付、门禁刷脸通行等场景
        /// </summary>
        [XmlElement("create_iot_group")]
        public bool CreateIotGroup { get; set; }

        /// <summary>
        /// 企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 订购【一脸通行开通插件】的小程序appId
        /// </summary>
        [XmlElement("group_app_id")]
        public string GroupAppId { get; set; }

        /// <summary>
        /// 管理员身份标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 管理员姓名
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 管理员身份openId
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 管理员身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业码签约后回跳地址
        /// </summary>
        [XmlElement("sign_return_url")]
        public string SignReturnUrl { get; set; }

        /// <summary>
        /// 管理员签约终端类型
        /// </summary>
        [XmlElement("sign_terminal")]
        public string SignTerminal { get; set; }
    }
}
