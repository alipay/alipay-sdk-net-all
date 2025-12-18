using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocAssetcountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocAssetcountQueryModel : AopObject
    {
        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }
    }
}
