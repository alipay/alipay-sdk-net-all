using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupinfoQueryModel : AopObject
    {
        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成，编辑群组必填
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
