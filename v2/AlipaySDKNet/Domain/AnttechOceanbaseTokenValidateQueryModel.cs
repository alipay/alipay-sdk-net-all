using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseTokenValidateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseTokenValidateQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 用户token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
