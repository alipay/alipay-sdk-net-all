using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollParticipantExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollParticipantExtInfo : AopObject
    {
        /// <summary>
        /// 门店地址信息
        /// </summary>
        [XmlElement("out_store_address")]
        public BsEnrollParticipantAddress OutStoreAddress { get; set; }

        /// <summary>
        /// 外部门店名称
        /// </summary>
        [XmlElement("out_store_name")]
        public string OutStoreName { get; set; }
    }
}
