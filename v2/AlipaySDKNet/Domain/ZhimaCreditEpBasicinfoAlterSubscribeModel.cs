using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpBasicinfoAlterSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpBasicinfoAlterSubscribeModel : AopObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 监听组号不填写，默认开通全部监听项；若要自定义监听项需联系客户经理进行配置
        /// </summary>
        [XmlElement("listen_group_id")]
        public string ListenGroupId { get; set; }

        /// <summary>
        /// 企业监听：EnterpriseListen
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
