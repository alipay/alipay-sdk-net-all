using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EapAuthVO Data Structure.
    /// </summary>
    [Serializable]
    public class EapAuthVO : AopObject
    {
        /// <summary>
        /// 该参数用来标识团餐所属组织，是根据用户corp按照组织归属转换得来，供应商会依据此参数合计账单。
        /// </summary>
        [XmlElement("corp")]
        public string Corp { get; set; }

        /// <summary>
        /// 该字段用来判断用户是否有权益查看蚂蚁套餐内容，是根据用户查询授权信息，若有授权，则具有权益，返回true，反之返回false。供应商会依据此参数，判断页面中是否展示蚂蚁套餐内容。
        /// </summary>
        [XmlElement("has_auth")]
        public bool HasAuth { get; set; }

        /// <summary>
        /// 该参数用来标识用户来源，是供应商不同的场景传入对应的来源，蚂蚁EAP会根据此来判断员工是否在权益范围内
        /// </summary>
        [XmlElement("source")]
        public long Source { get; set; }
    }
}
