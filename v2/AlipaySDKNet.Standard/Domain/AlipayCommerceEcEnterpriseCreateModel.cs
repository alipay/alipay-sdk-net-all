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
        /// 是否创建企业人脸库，适用于对接团餐刷脸付、门禁刷脸通行等场景，不传默认为true
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
        /// 身份，对应身份类型进行传参，例如： 企业支付宝登录账号(支持手机号或者邮箱)或企业支付宝会员id(对应2088开头的支付宝会员id)
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 当identity_type为ALIPAY_USER_ID时，此字段传入open_id
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 身份类型,目前支持传参如下： ALIPAY_LOGON_ID(企业支付宝登录账号) ALIPAY_USER_ID(企业支付宝会员id)
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号 1.作为创建该企业的唯一幂等标识，不传默认使用identity幂等 2.传入out_biz_no创建返回结果成功后，如需再新建其他企业，则out_biz_no传不同的参数，否则会被幂等 3.如果调用失败或者超时，可以使用相同的outBizNo进行重试处理 4.并发使用相同outBizNo调用，会返回企业创建中，不要重复操作的错误信息
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
