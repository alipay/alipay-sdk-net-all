using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCertificationInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpCertificationInitializeResponse : AopResponse
    {
        /// <summary>
        /// 一次认证的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }
    }
}
