using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierLabelQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业标签内容列表
        /// </summary>
        [XmlArray("label_content")]
        [XmlArrayItem("ep_label_content")]
        public List<EpLabelContent> LabelContent { get; set; }
    }
}
