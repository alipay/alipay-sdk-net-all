using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FmBindFmVO Data Structure.
    /// </summary>
    [Serializable]
    public class FmBindFmVO : AopObject
    {
        /// <summary>
        /// 用户证件号，不脱敏
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// ● 01-居民身份证 ● 02-护照 ● 03-军官证 ● 04-士兵证 ● 05-户口本 ● 06-警官证 ● 07-台湾居民来往大陆通行证（简称“回乡证”） ● 08-港澳居民来往内地通行证（简称“回乡证”） ● 09-临时身份证 ● 10-港澳通行证 ● 11-营业执照 ● 13-香港身份证 ● 15-组织机构代码证 ● 16-行政机关 ● 17-社会团体 ● 19-台湾居民来往大陆通行证 ● 20-港澳居民居住证 ● 21-台湾居民居住证 ● 22-外国人永久居留证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// ● FEMALE-女性 ● MALE-男性
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// ● 03-其他 ● 06-父母 ● 07-子女 ● 08-配偶
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 用户真实姓名，不脱敏
        /// </summary>
        [XmlElement("user_real_name")]
        public string UserRealName { get; set; }
    }
}
