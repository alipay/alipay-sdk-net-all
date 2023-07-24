using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthenticationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingAuthenticationApplyModel : AopObject
    {
        /// <summary>
        /// 授权跳转类型
        /// </summary>
        [XmlElement("apply_link_type")]
        public string ApplyLinkType { get; set; }

        /// <summary>
        /// 核身完成跳转链接
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 如果入参传了back_url，则此参数也需要传入，参数只支持tinyapp、thirdapp、h5 三种格式。不传默认为tinyapp
        /// </summary>
        [XmlElement("back_url_type")]
        public string BackUrlType { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 零工卡工牌信息
        /// </summary>
        [XmlElement("employee_card_no")]
        public string EmployeeCardNo { get; set; }

        /// <summary>
        /// 超时时间，建议在距离接口请求时间2小时到3天之间。
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，幂等关键参数。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 进行核身的主体信息
        /// </summary>
        [XmlElement("principal_info")]
        public ParticipantDTO PrincipalInfo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
