using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertifyConfig Data Structure.
    /// </summary>
    [Serializable]
    public class CertifyConfig : AopObject
    {
        /// <summary>
        /// 核验模式，可选范围：【FACE : 人脸认证 ，  CERT_PHOTO_FACE : 证照和人脸认证】
        /// </summary>
        [XmlElement("certify_biz_code")]
        public string CertifyBizCode { get; set; }

        /// <summary>
        /// 是否要地址，可选范围【0， 1】 0不需要，1需要，不填写或填错默认1
        /// </summary>
        [XmlElement("need_address")]
        public string NeedAddress { get; set; }

        /// <summary>
        /// 结果页是否需要展示支付宝侧登记码，可选范围【0， 1】0不需要，1需要，不填写或填错默认1。若不需要展示支付宝侧登记码，则需要isv实时返回isv侧登记码，不返回则不显示登记码
        /// </summary>
        [XmlElement("need_certify_id")]
        public string NeedCertifyId { get; set; }

        /// <summary>
        /// 是否要性别，可选范围【0， 1】 0不需要，1需要，不填写或填错默认1
        /// </summary>
        [XmlElement("need_gender")]
        public string NeedGender { get; set; }

        /// <summary>
        /// 是否要手机号，可选范围【0， 1】 0不需要，1需要，不填写或填错默认1
        /// </summary>
        [XmlElement("need_phone")]
        public string NeedPhone { get; set; }

        /// <summary>
        /// 是否要民族，可选范围【0， 1】 0不需要，1需要，不填写或填错默认1
        /// </summary>
        [XmlElement("need_user_nation")]
        public string NeedUserNation { get; set; }
    }
}
