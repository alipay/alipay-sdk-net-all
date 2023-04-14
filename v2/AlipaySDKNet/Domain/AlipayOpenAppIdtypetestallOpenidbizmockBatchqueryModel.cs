using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppIdtypetestallOpenidbizmockBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppIdtypetestallOpenidbizmockBatchqueryModel : AopObject
    {
        /// <summary>
        /// 额外参数
        /// </summary>
        [XmlElement("extra_param_input")]
        public string ExtraParamInput { get; set; }

        /// <summary>
        /// id_type
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type_list")]
        public string IdTypeList { get; set; }

        /// <summary>
        /// idtype
        /// </summary>
        [XmlElement("id_type_test_complex_param")]
        public IdTypeTestComplexParam IdTypeTestComplexParam { get; set; }

        /// <summary>
        /// idType复杂类型列表
        /// </summary>
        [XmlArray("id_type_test_complex_param_list")]
        [XmlArrayItem("id_type_test_complex_param")]
        public List<IdTypeTestComplexParam> IdTypeTestComplexParamList { get; set; }

        /// <summary>
        /// openaId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// openId列表
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
        /// uid列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
