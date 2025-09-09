using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchooldeviceSmCheckResponse.
    /// </summary>
    public class AlipayCommerceEducateSchooldeviceSmCheckResponse : AopResponse
    {
        /// <summary>
        /// 间联商户名称
        /// </summary>
        [XmlElement("sm_cn_name")]
        public string SmCnName { get; set; }

        /// <summary>
        /// 间联商户经营类目名称
        /// </summary>
        [XmlElement("sm_mcc_name")]
        public string SmMccName { get; set; }

        /// <summary>
        /// 间联商户新经营类目名称
        /// </summary>
        [XmlElement("sm_new_mcc_ame")]
        public string SmNewMccAme { get; set; }
    }
}
