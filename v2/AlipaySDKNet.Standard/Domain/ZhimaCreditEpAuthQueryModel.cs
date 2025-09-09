using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAuthQueryModel : AopObject
    {
        /// <summary>
        /// 企业信用赋予的唯一业务标识id，在企信小程序跳转到对方承接页时会带有bizNo，对方通过该方式获取该唯一id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 要查询授权数据的统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
