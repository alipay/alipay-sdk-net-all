using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepaySignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepaySignModel : AopObject
    {
        /// <summary>
        /// 企业简称，传空采用默认规则命名，使用公司名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 指定签约终端类型 PC-电脑浏览器 MOBILE-手机端
        /// </summary>
        [XmlElement("appoint_sign_terminal")]
        public string AppointSignTerminal { get; set; }

        /// <summary>
        /// 业务场景，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 特殊场景下扩展字段
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 开户账号： 当identity_type是ALIPAY_USER_ID时填支付宝会员ID（2088开头）； 当identity_type是ALIPAY_LOGON_ID 时填支付宝登录号； 当identity_type是OUT_USER_ID时填外部平台的用户uid; 当identity_type是ALIPAY_OPEN_ID时填用户openId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 开户用户名称，identity_type为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、OUT_USER_ID：外部用户uid
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 商户侧单号（幂等字段） ，补充说明：幂等逻辑（商户appid+out_biz_no），商户集成时需注意，如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部实体ID，一般表述为外部操作人操作某个外部实体。比如企业码2284号
        /// </summary>
        [XmlElement("out_entity_id")]
        public string OutEntityId { get; set; }

        /// <summary>
        /// ISV平台定义的共同账户开户来源
        /// </summary>
        [XmlElement("out_source")]
        public string OutSource { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
