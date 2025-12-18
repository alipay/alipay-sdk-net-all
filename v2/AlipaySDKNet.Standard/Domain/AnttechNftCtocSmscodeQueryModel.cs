using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocSmscodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocSmscodeQueryModel : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 枚举： OPEN_UID-鲸探openUid
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 秒转验证码
        /// </summary>
        [XmlElement("sms_biz_scene")]
        public string SmsBizScene { get; set; }
    }
}
