using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataMedicalSuwenConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataMedicalSuwenConsultModel : AopObject
    {
        /// <summary>
        /// 咨询数据类型，如doctor（医生）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 咨询场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 查询条件，如医生证号查询：{"name":"license_no","value":"12345"}
        /// </summary>
        [XmlArray("search_list")]
        [XmlArrayItem("consult_item")]
        public List<ConsultItem> SearchList { get; set; }

        /// <summary>
        /// 需要咨询的字段列表，如{"name":"scope"}
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("consult_item")]
        public List<ConsultItem> TargetList { get; set; }
    }
}
