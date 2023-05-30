using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingRtaSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingRtaSendModel : AopObject
    {
        /// <summary>
        /// 活动id描述具体给用户发奖的活动，预发奖时可以为空
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 身份证加密值，规则由业务确定，login_id_encryption、cert_encryption、mobile_encryption不能同时为空，优先级依次递减
        /// </summary>
        [XmlElement("cert_encryption")]
        public string CertEncryption { get; set; }

        /// <summary>
        /// 加密类型，参数值大写，如：SHA256或者SM3
        /// </summary>
        [XmlElement("encryption_type")]
        public string EncryptionType { get; set; }

        /// <summary>
        /// 扩展字段，保留扩展配置字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 支付宝登录账号，唯一确定发奖的支付宝账号信息，采用登录名用encryption_type加密方式加密获取的值，login_id_encryption、cert_encryption、mobile_encryption不能同时为空，优先级依次递减
        /// </summary>
        [XmlElement("login_id_encryption")]
        public string LoginIdEncryption { get; set; }

        /// <summary>
        /// 手机号码加密值，手机号以encryption_type加密方式加密获取的值，login_id_encryption、cert_encryption、mobile_encryption不能同时为空，优先级依次递减
        /// </summary>
        [XmlElement("mobile_encryption")]
        public string MobileEncryption { get; set; }

        /// <summary>
        /// 外部业务号，业务的标识由商户生成，可以设置成订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商务项目ID，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 摩斯营销发奖类型，明确本次调用是预发奖或者发奖，发奖环节可以配置验证预发奖验证，二段式降低发奖风险。参数值大写，【PREGRANT：预发奖；GRANT：发奖】
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }

        /// <summary>
        /// 用户达标时间，精确到秒
        /// </summary>
        [XmlElement("user_pass_time")]
        public string UserPassTime { get; set; }
    }
}
