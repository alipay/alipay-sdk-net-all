using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertdocCertverifyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertdocCertverifyConsultModel : AopObject
    {
        /// <summary>
        /// 信息校验验证ID。通过<a href="https://opendocs.alipay.com/apis/api_2/alipay.user.certdoc.certverify.preconsult">alipay.user.certdoc.certverify.preconsult</a>(实名证件信息比对验证预咨询)接口获取。
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
