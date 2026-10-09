using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationAlipayaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationAlipayaccountQueryModel : AopObject
    {
        /// <summary>
        /// 商业组织关系中商圈的ownerPid
        /// </summary>
        [XmlElement("mall_pid")]
        public string MallPid { get; set; }

        /// <summary>
        /// 商业关系中的门店收单pid
        /// </summary>
        [XmlElement("shopmember_pid")]
        public string ShopmemberPid { get; set; }
    }
}
