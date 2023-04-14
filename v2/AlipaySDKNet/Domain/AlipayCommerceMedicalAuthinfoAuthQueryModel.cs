using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthinfoAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthinfoAuthQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授权回调地址
        /// </summary>
        [XmlElement("call_url")]
        public string CallUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_params")]
        public AuthExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("ins_code")]
        public string InsCode { get; set; }

        /// <summary>
        /// 线上业务类型编码
        /// </summary>
        [XmlElement("ol_biz_type_code")]
        public string OlBizTypeCode { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// olBizTypeCode=04107(医保移动支付业务)时必传
        /// </summary>
        [XmlElement("org_app_id")]
        public string OrgAppId { get; set; }

        /// <summary>
        /// 机构渠道认证编码
        /// </summary>
        [XmlElement("org_chnl_crtf_code")]
        public string OrgChnlCrtfCode { get; set; }

        /// <summary>
        /// 定点医药机构代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 商户请求流水号
        /// </summary>
        [XmlElement("req_biz_no")]
        public string ReqBizNo { get; set; }
    }
}
