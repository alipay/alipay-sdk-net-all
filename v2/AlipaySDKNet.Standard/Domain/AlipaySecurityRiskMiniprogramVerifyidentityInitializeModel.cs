using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskMiniprogramVerifyidentityInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskMiniprogramVerifyidentityInitializeModel : AopObject
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 接入业务方业务唯一性id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 核验服务名称，目前仅支持人脸，后续支持多因子核身产品
        /// </summary>
        [XmlArray("product_code")]
        [XmlArrayItem("string")]
        public List<string> ProductCode { get; set; }

        /// <summary>
        /// 身份核验场景CODE，为接入场景的英文名称，比如登陆login, 风险校验riskVerify, 支付payment等，需保证同一商户下多种接入场景code的唯一性
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景参数： 1. renderGroup为渲染形态，有native或h5； 2. envData为设备信息，通过客户端采集； 3. 认证信息授权authFlag，R为仅人脸认证结果，A为认证结果和人脸图像； 4. 核身回调方式callBackActionCode：Native_CB_Native
        /// </summary>
        [XmlElement("scene_params")]
        public SceneParams SceneParams { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
