using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRebusinessentityPersonQueryResponse.
    /// </summary>
    public class ZhimaCreditEpRebusinessentityPersonQueryResponse : AopResponse
    {
        /// <summary>
        /// 关系数据集
        /// </summary>
        [XmlElement("data")]
        public RebusinessEntityRelation Data { get; set; }

        /// <summary>
        /// 法人姓名（同入参）
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }

        /// <summary>
        /// 企业18位统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
