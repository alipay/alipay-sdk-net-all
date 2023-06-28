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
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否设置管理员支付宝为企业出资账户，不传默认为true
        /// </summary>
        [XmlElement("create_fund_account")]
        public bool CreateFundAccount { get; set; }

        /// <summary>
        /// 是否创建企业人脸库，适用于对接团餐刷脸付、门禁刷脸通行等场景；不传默认创建，创建失败不会阻塞企业的创建；如果传true且创建失败，则会阻塞企业的创建。
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
        /// 管理员身份标识，对应identity_type进行传参： 1. 手机号或者邮箱（当身份类型传ALIPAY_LOGON_ID时） 2. 支付宝会员id（当身份类型传ALIPAY_USER_ID时） 3. 服务商用户id（当身份类型传ISV_USER_ID时）
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 管理员姓名，当身份类型传ISV_USER_ID时，这个字段必传
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 当identity_type为ALIPAY_USER_ID时，此字段传入open_id
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 管理员身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号 1.作为创建该企业的唯一幂等标识，不传默认使用identity幂等 2.传入out_biz_no创建返回结果成功后，如需再新建其他企业，则out_biz_no传不同的参数，否则会被幂等 3.如果调用失败或者超时，可以使用相同的outBizNo进行重试处理 4.并发使用相同outBizNo调用，会返回企业创建中，不要重复操作的错误信息
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业码签约后回跳地址，pc端支持回跳任意http地址，移动端仅支持回跳支付宝或钉钉地址，不传默认为空
        /// </summary>
        [XmlElement("sign_return_url")]
        public string SignReturnUrl { get; set; }

        /// <summary>
        /// 管理员签约终端类型，不传默认为PC
        /// </summary>
        [XmlElement("sign_terminal")]
        public string SignTerminal { get; set; }
    }
}
