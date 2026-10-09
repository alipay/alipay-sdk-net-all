using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppIdtypetestallOpenidbizmockBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppIdtypetestallOpenidbizmockBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// uid列表
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type_list")]
        public string IdTypeList { get; set; }

        /// <summary>
        /// 复杂类型
        /// </summary>
        [XmlElement("id_type_test_complex_param")]
        public IdTypeTestComplexParam IdTypeTestComplexParam { get; set; }

        /// <summary>
        /// 复杂类型列表
        /// </summary>
        [XmlArray("id_type_test_complex_param_list")]
        [XmlArrayItem("id_type_test_complex_param")]
        public List<IdTypeTestComplexParam> IdTypeTestComplexParamList { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// OPENID_LIST
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// UID
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// zone
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }

        /// <summary>
        /// zone类型
        /// </summary>
        [XmlElement("zone_type")]
        public string ZoneType { get; set; }
    }
}
