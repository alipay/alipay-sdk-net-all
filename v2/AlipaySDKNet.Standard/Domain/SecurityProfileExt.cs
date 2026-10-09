using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecurityProfileExt Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityProfileExt : AopObject
    {
        /// <summary>
        /// 密钥类型
        /// </summary>
        [XmlElement("enc_style")]
        public string EncStyle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// disable时间
        /// </summary>
        [XmlElement("gmt_disable")]
        public string GmtDisable { get; set; }

        /// <summary>
        /// enable时间
        /// </summary>
        [XmlElement("gmt_enable")]
        public string GmtEnable { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// dec_algo
        /// </summary>
        [XmlElement("req_dec_algo")]
        public string ReqDecAlgo { get; set; }

        /// <summary>
        /// dec_key
        /// </summary>
        [XmlElement("req_dec_key")]
        public string ReqDecKey { get; set; }

        /// <summary>
        /// verify
        /// </summary>
        [XmlElement("req_verify_algo")]
        public string ReqVerifyAlgo { get; set; }

        /// <summary>
        /// verify_key
        /// </summary>
        [XmlElement("req_verify_key")]
        public string ReqVerifyKey { get; set; }

        /// <summary>
        /// dec_key
        /// </summary>
        [XmlElement("res_dec_key")]
        public string ResDecKey { get; set; }

        /// <summary>
        /// enc_algo
        /// </summary>
        [XmlElement("res_enc_algo")]
        public string ResEncAlgo { get; set; }

        /// <summary>
        /// enc_key
        /// </summary>
        [XmlElement("res_enc_key")]
        public string ResEncKey { get; set; }

        /// <summary>
        /// sign_algo
        /// </summary>
        [XmlElement("res_sign_algo")]
        public string ResSignAlgo { get; set; }

        /// <summary>
        /// 支付宝私钥别名
        /// </summary>
        [XmlElement("res_sign_alias")]
        public string ResSignAlias { get; set; }

        /// <summary>
        /// sign_key
        /// </summary>
        [XmlElement("res_sign_key")]
        public string ResSignKey { get; set; }

        /// <summary>
        /// 支付宝公钥别名
        /// </summary>
        [XmlElement("res_verify_alias")]
        public string ResVerifyAlias { get; set; }

        /// <summary>
        /// verify_key
        /// </summary>
        [XmlElement("res_verify_key")]
        public string ResVerifyKey { get; set; }

        /// <summary>
        /// 密钥描述
        /// </summary>
        [XmlElement("sec_des")]
        public string SecDes { get; set; }

        /// <summary>
        /// 密钥ID
        /// </summary>
        [XmlElement("sec_id")]
        public string SecId { get; set; }

        /// <summary>
        /// 密钥证书的配置信息
        /// </summary>
        [XmlElement("security_cert_profile_ext")]
        public SecurityCertProfileExt SecurityCertProfileExt { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [XmlElement("sign_style")]
        public string SignStyle { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("sub_sec_id")]
        public string SubSecId { get; set; }
    }
}
