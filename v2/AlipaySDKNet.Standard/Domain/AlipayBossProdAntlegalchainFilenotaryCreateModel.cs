using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainFilenotaryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainFilenotaryCreateModel : AopObject
    {
        /// <summary>
        /// 业务应用英文名
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 业务唯一流水id，业务数据请求唯一标识
        /// </summary>
        [XmlElement("business_unique_id")]
        public string BusinessUniqueId { get; set; }

        /// <summary>
        /// 客户的实名信息，注意不能和entity的certno相同
        /// </summary>
        [XmlElement("customer")]
        public IdentityDTO Customer { get; set; }

        /// <summary>
        /// 自己的实名信息
        /// </summary>
        [XmlElement("entity")]
        public IdentityDTO Entity { get; set; }

        /// <summary>
        /// 文件id,从openapi接口alipay.boss.prod.antlegalchain.notary.upload获得file_id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [XmlElement("location")]
        public LocationDTO Location { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 提交人姓名
        /// </summary>
        [XmlElement("submitter_name")]
        public string SubmitterName { get; set; }

        /// <summary>
        /// 提交人用户id
        /// </summary>
        [XmlElement("submitter_uid")]
        public string SubmitterUid { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 业务系统被分配的密钥key
        /// </summary>
        [XmlElement("token_key")]
        public string TokenKey { get; set; }
    }
}
