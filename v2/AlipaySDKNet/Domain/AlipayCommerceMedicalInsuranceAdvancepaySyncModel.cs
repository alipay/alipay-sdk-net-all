using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceAdvancepaySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceAdvancepaySyncModel : AopObject
    {
        /// <summary>
        /// 垫付申请结果描述。垫付申请失败时，需给出失败原因
        /// </summary>
        [XmlElement("advance_apply_desc")]
        public string AdvanceApplyDesc { get; set; }

        /// <summary>
        /// 唯一标识一次垫付申请，返回最近一次的垫付申请。
        /// </summary>
        [XmlElement("advance_apply_no")]
        public string AdvanceApplyNo { get; set; }

        /// <summary>
        /// 用户申请垫付后，垫资方返回的垫付申请状态
        /// </summary>
        [XmlElement("advance_apply_status")]
        public string AdvanceApplyStatus { get; set; }

        /// <summary>
        /// 支付宝垫付申请号
        /// </summary>
        [XmlElement("ant_apply_no")]
        public string AntApplyNo { get; set; }

        /// <summary>
        /// 垫资对应的蚂蚁保保单号，蚂蚁保入口发起垫资申请，传入蚂蚁保保单号，垫资方根据垫资申请关联上对应的蚂蚁保保单号
        /// </summary>
        [XmlElement("ant_policy_no")]
        public string AntPolicyNo { get; set; }

        /// <summary>
        /// 本次垫付可用的垫付金额，单位：元
        /// </summary>
        [XmlElement("available_advance_amount")]
        public string AvailableAdvanceAmount { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("business_no")]
        public string BusinessNo { get; set; }

        /// <summary>
        /// 业务进度生效时间（非报文同步时间）
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 证件号，例如：身份证证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户在中国大陆使用的标识个人身份的证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 标识实际赔付的保险公司，由支付宝定义枚举值，垫资的实际理赔保司为众安，那么枚举值为ZHONGAN
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 最近一次授信流水号，进度同步时可空，授信金额回传时传入
        /// </summary>
        [XmlElement("grant_serial_no")]
        public string GrantSerialNo { get; set; }

        /// <summary>
        /// 补充材料信息
        /// </summary>
        [XmlArray("lack_materials")]
        [XmlArrayItem("lack_material")]
        public List<LackMaterial> LackMaterials { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 垫付申请的外部医院id，由保司和垫资方线下同步给支付宝侧绑定
        /// </summary>
        [XmlElement("out_hospital_id")]
        public string OutHospitalId { get; set; }

        /// <summary>
        /// 垫资对应保司的用户保单号，如垫资的实际理赔保司为众安，那么该保单号为众安对应的保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 标识垫资方的身份来源，支付宝定义的枚举值，对应到具体的垫资调用方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 标识本笔垫资的状态，0-欠费，1-正常，2-理赔中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
