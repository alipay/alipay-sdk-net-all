using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLifeaccountInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLifeaccountInfoModifyModel : AopObject
    {
        /// <summary>
        /// 医生描述，如职称等信息
        /// </summary>
        [XmlElement("doctor_desc")]
        public string DoctorDesc { get; set; }

        /// <summary>
        /// 加密后的好大夫id，与public id一起指定一个操作用户
        /// </summary>
        [XmlElement("hdf_id_encrypted")]
        public string HdfIdEncrypted { get; set; }

        /// <summary>
        /// 头像链接
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 账号描述
        /// </summary>
        [XmlElement("public_desc")]
        public string PublicDesc { get; set; }

        /// <summary>
        /// 需要修改信息的号id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 修改后的号名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }
    }
}
