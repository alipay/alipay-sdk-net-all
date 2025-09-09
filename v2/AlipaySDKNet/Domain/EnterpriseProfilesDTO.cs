using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseProfilesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseProfilesDTO : AopObject
    {
        /// <summary>
        /// 企业注册来源，仅特定场景需要传值
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 是否需要自动创建企业人脸库，适用于对接团餐刷脸付、门禁刷脸通行等场景；<br/> 不传默认为 false，传 true 时会自动创建企业的 IOT 设备人脸库，人脸库创建失败会阻塞企业注册
        /// </summary>
        [XmlElement("create_iot_group")]
        public bool CreateIotGroup { get; set; }

        /// <summary>
        /// 企业授信申请人的手机号码；<br/> 当出资方式为企业授信出资时(sign_fund_way=CREDIT)，会用于银行授信申请页面免登
        /// </summary>
        [XmlElement("credit_applicant_mobile")]
        public string CreditApplicantMobile { get; set; }

        /// <summary>
        /// 用于区分资金因公付协议、以及收银台文案等差异；不传默认为ISV_QYM。
        /// </summary>
        [XmlElement("fund_biz_scene")]
        public string FundBizScene { get; set; }

        /// <summary>
        /// 对接支付宝「一脸通行开通插件」的支付宝小程序appId
        /// </summary>
        [XmlElement("group_app_id")]
        public string GroupAppId { get; set; }

        /// <summary>
        /// 接口返回的PC端企业注册链接，需适用的集成模式；<br/>不传默认为网页跳转的模式，需要跳转页面链接进入企业注册页面；如需以页面组件嵌入其他系统，请传入iframe
        /// </summary>
        [XmlElement("pc_invite_url_mode")]
        public string PcInviteUrlMode { get; set; }
    }
}
