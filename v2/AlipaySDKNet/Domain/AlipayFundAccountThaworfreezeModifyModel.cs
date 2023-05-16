using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountThaworfreezeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountThaworfreezeModifyModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [XmlElement("business_lice")]
        public string BusinessLice { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型：thaw（开启)、freeze（冻结)
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 淘宝协议id
        /// </summary>
        [XmlElement("taobao_agreement_id")]
        public string TaobaoAgreementId { get; set; }

        /// <summary>
        /// 淘宝协议签署时间
        /// </summary>
        [XmlElement("taobao_sign_time")]
        public string TaobaoSignTime { get; set; }

        /// <summary>
        /// 淘宝uid
        /// </summary>
        [XmlElement("taobao_user_id")]
        public string TaobaoUserId { get; set; }

        /// <summary>
        /// 淘宝用户类型
        /// </summary>
        [XmlElement("taobao_user_type")]
        public string TaobaoUserType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
