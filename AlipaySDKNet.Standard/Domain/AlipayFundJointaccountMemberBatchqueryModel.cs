using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountMemberBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountMemberBatchqueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业账号：identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）； 是ALIPAY_LOGON_ID 填支付宝登录号
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 按游标查询，传入上次查询最后一个用户的openId
        /// </summary>
        [XmlElement("last_open_id")]
        public string LastOpenId { get; set; }

        /// <summary>
        /// 按游标查询，传入上次查询最后一个用户ID，适用于逐页查询。优先级大于page_num
        /// </summary>
        [XmlElement("last_user_id")]
        public string LastUserId { get; set; }

        /// <summary>
        /// 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据。
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小，不传的情况下默认20条，上限100；不足20条则按实际记录数返回
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
