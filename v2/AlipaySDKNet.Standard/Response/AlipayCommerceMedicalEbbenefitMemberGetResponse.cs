using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalEbbenefitMemberGetResponse : AopResponse
    {
        /// <summary>
        /// 家庭成员地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否绑定好大夫服务，0：未绑定，1：已绑定
        /// </summary>
        [XmlElement("binding_hdf_service")]
        public string BindingHdfService { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 年月日
        /// </summary>
        [XmlElement("member_birthday")]
        public string MemberBirthday { get; set; }

        /// <summary>
        /// 证件类型 01-身份证
        /// </summary>
        [XmlElement("member_cert_type")]
        public string MemberCertType { get; set; }

        /// <summary>
        /// 家庭成员性别  MALE:男 FEMALE:女
        /// </summary>
        [XmlElement("member_gender")]
        public string MemberGender { get; set; }

        /// <summary>
        /// 支付宝家庭成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("member_id_no")]
        public string MemberIdNo { get; set; }

        /// <summary>
        /// 家庭成员姓名
        /// </summary>
        [XmlElement("member_name")]
        public string MemberName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("member_phone_no")]
        public string MemberPhoneNo { get; set; }

        /// <summary>
        /// 外部家庭成员id
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 关系 myself：本人、parent：父母、 child：子女、spouse：配偶、friend_relative：亲朋、other：其他
        /// </summary>
        [XmlElement("rel")]
        public string Rel { get; set; }
    }
}
