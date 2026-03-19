using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftUserChainQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftUserChainQueryModel : AopObject
    {
        /// <summary>
        /// 鲸探用户ID，可以为手机号、openUid
        /// </summary>
        [XmlElement("fans_id")]
        public string FansId { get; set; }

        /// <summary>
        /// 鲸探用户ID类型
        /// </summary>
        [XmlElement("fans_id_type")]
        public string FansIdType { get; set; }
    }
}
