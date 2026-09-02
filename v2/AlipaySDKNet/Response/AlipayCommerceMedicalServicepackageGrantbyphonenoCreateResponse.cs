using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sub_unique_biz_info_list")]
        [XmlArrayItem("unique_biz_info")]
        public List<UniqueBizInfo> SubUniqueBizInfoList { get; set; }

        /// <summary>
        /// 业务唯一单号
        /// </summary>
        [XmlElement("unique_biz_no")]
        public string UniqueBizNo { get; set; }
    }
}
